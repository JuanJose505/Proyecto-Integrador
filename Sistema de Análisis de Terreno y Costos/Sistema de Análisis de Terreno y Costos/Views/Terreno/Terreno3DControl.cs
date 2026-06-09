using OpenTK;
using OpenTK.Graphics;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Guna.UI2.WinForms.Suite.Descriptions;
using OpenTK.Graphics.OpenGL;


namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views.Terreno
{
    public class Terreno3DControl : UserControl
    {
        // ── Superficie OpenGL ────────────────────────────────────────
        private GLControl _gl;
        private bool _listo;

        // ── Datos del terreno ────────────────────────────────────────
        private List<PuntoTerreno> _puntos = new List<PuntoTerreno>();
        private double[,] _Z;
        private Vector3[,] _N;
        private float[] _xs = new float[0];
        private float[] _ys = new float[0];

        // ── Bounding box ─────────────────────────────────────────────
        private float _xMin, _xMax, _yMin, _yMax, _zMin, _zMax;
        private float _cx, _cy, _cz, _escala;

        // ── Cámara orbital ───────────────────────────────────────────
        private float _theta = 45f;
        private float _phi = 35f;
        private float _dist = 4.0f;
        private float _panX, _panY;

        // ── Estado del mouse ─────────────────────────────────────────
        private Point _ultimoMouse;
        private bool _botonIzq, _botonDer;

        // ── Dirección de la luz ──────────────────────────────────────
        private static readonly Vector3 LUZ = Normalizar(new Vector3(1f, 0.8f, 2f));

        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public Terreno3DControl()
        {
            CrearControles();
        }

        // ============================================================
        // CREACIÓN DE CONTROLES
        // ============================================================
        private void CrearControles()
        {
            var titulo = new Label
            {
                Text = "Vista 3D del Terreno",
                Dock = DockStyle.Top,
                Height = 28,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                BackColor = Color.FromArgb(30, 58, 95),
                ForeColor = Color.White
            };

            try
            {
                _gl = new GLControl(new GraphicsMode(32, 24, 0, 4))
                {
                    Dock = DockStyle.Fill,
                    VSync = true
                };

                _gl.Load += OnGLLoad;
                _gl.Resize += OnGLResize;
                _gl.Paint += OnGLPaint;
                _gl.MouseDown += OnMouseDown2;
                _gl.MouseMove += OnMouseMove2;
                _gl.MouseUp += OnMouseUp2;
                _gl.MouseWheel += OnMouseWheel2;
                _gl.DoubleClick += OnDobleClick;

                Controls.Add(_gl);
            }
            catch (Exception ex)
            {
                Controls.Add(new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"Vista 3D no disponible:\n{ex.Message}",
                    ForeColor = Color.OrangeRed
                });
            }

            Controls.Add(titulo);
        }

        // ============================================================
        // API PÚBLICA
        // ============================================================
        public void CargarPuntos(IEnumerable<PuntoTerreno> puntos)
        {
            _puntos = puntos.ToList();
            ConstruirMalla();
            if (_listo) _gl?.Invalidate();
        }

        // ============================================================
        // EVENTOS OPENGL
        // ============================================================
        private void OnGLLoad(object sender, EventArgs e)
        {
            _listo = true;
            _gl.MakeCurrent();

            GL.ClearColor(0.07f, 0.10f, 0.15f, 1f);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.ShadeModel(ShadingModel.Smooth);

            OnGLResize(sender, e);
            if (_puntos.Count > 0) ConstruirMalla();
            _gl.Invalidate();
        }

        private void OnGLResize(object sender, EventArgs e)
        {
            if (!_listo) return;
            _gl.MakeCurrent();

            int w = Math.Max(_gl.Width, 1);
            int h = Math.Max(_gl.Height, 1);
            GL.Viewport(0, 0, w, h);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            var p = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(40f), (float)w / h, 0.001f, 200f);
            GL.LoadMatrix(ref p);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        private void OnGLPaint(object sender, PaintEventArgs e)
        {
            if (!_listo) return;
            RenderizarEscena();
            _gl.SwapBuffers();

            using (var g = _gl.CreateGraphics())
            {
                DibujarLeyenda(g);
                DibujarAyuda(g);
            }
        }

        // ============================================================
        // EVENTOS DEL MOUSE
        // ============================================================
        private void OnMouseDown2(object sender, MouseEventArgs e)
        {
            _ultimoMouse = e.Location;
            _botonIzq = e.Button == MouseButtons.Left;
            _botonDer = e.Button == MouseButtons.Right;
        }

        private void OnMouseMove2(object sender, MouseEventArgs e)
        {
            if (!_botonIzq && !_botonDer) return;

            float dx = e.X - _ultimoMouse.X;
            float dy = e.Y - _ultimoMouse.Y;

            if (_botonIzq)
            {
                _theta -= dx * 0.4f;
                _phi = Math.Max(-89f, Math.Min(89f, _phi + dy * 0.4f));
            }
            if (_botonDer)
            {
                _panX += dx * 0.003f;
                _panY -= dy * 0.003f;
            }

            _ultimoMouse = e.Location;
            _gl.Invalidate();
        }

        private void OnMouseUp2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) _botonIzq = false;
            if (e.Button == MouseButtons.Right) _botonDer = false;
        }

        private void OnMouseWheel2(object sender, MouseEventArgs e)
        {
            _dist = Math.Max(0.3f, Math.Min(40f,
                _dist * (e.Delta > 0 ? 0.88f : 1.13f)));
            _gl.Invalidate();
        }

        private void OnDobleClick(object sender, EventArgs e)
        {
            _theta = 45f; _phi = 35f; _dist = 4f; _panX = 0; _panY = 0;
            _gl.Invalidate();
        }

        // ============================================================
        // RENDERIZADO 3D
        // ============================================================
        private void RenderizarEscena()
        {
            _gl.MakeCurrent();
            int w = Math.Max(_gl.Width, 1), h = Math.Max(_gl.Height, 1);
            GL.Viewport(0, 0, w, h);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            float tRad = MathHelper.DegreesToRadians(_theta);
            float pRad = MathHelper.DegreesToRadians(_phi);
            float eyeX = _dist * (float)(Math.Cos(pRad) * Math.Cos(tRad));
            float eyeY = _dist * (float)(Math.Cos(pRad) * Math.Sin(tRad));
            float eyeZ = _dist * (float)Math.Sin(pRad);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            var proj = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(40f), (float)w / h, 0.001f, 200f);
            GL.LoadMatrix(ref proj);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            var vista = Matrix4.LookAt(
                new Vector3(eyeX, eyeY, eyeZ), Vector3.Zero, Vector3.UnitZ);
            GL.LoadMatrix(ref vista);

            GL.Translate(_panX, _panY, 0f);
            GL.Scale(_escala, _escala, _escala);
            GL.Translate(-_cx, -_cy, -_cz);

            if (_Z != null)
            {
                DibujarSuperficie();
                DibujarWireframe();
                DibujarEjes();
            }
            else
            {
                DibujarNubePuntos();
            }
        }

        private void DibujarSuperficie()
        {
            GL.PolygonOffset(1f, 1f);
            GL.Enable(EnableCap.PolygonOffsetFill);

            int nx = _xs.Length, ny = _ys.Length;
            for (int xi = 0; xi < nx - 1; xi++)
            {
                GL.Begin(PrimitiveType.QuadStrip);
                for (int yi = 0; yi < ny; yi++)
                {
                    var c0 = ColorConLuz(xi, yi);
                    var c1 = ColorConLuz(xi + 1, yi);
                    GL.Color3(c0.r, c0.g, c0.b);
                    GL.Vertex3(_xs[xi], _ys[yi], (float)_Z[xi, yi]);
                    GL.Color3(c1.r, c1.g, c1.b);
                    GL.Vertex3(_xs[xi + 1], _ys[yi], (float)_Z[xi + 1, yi]);
                }
                GL.End();
            }

            GL.Disable(EnableCap.PolygonOffsetFill);
        }

        private void DibujarWireframe()
        {
            GL.LineWidth(0.8f);
            GL.Color4(0f, 0f, 0f, 0.22f);
            const float OFF = 0.02f;
            int nx = _xs.Length, ny = _ys.Length;

            for (int yi = 0; yi < ny; yi++)
            {
                GL.Begin(PrimitiveType.LineStrip);
                for (int xi = 0; xi < nx; xi++)
                    GL.Vertex3(_xs[xi], _ys[yi], (float)_Z[xi, yi] + OFF);
                GL.End();
            }
            for (int xi = 0; xi < nx; xi++)
            {
                GL.Begin(PrimitiveType.LineStrip);
                for (int yi = 0; yi < ny; yi++)
                    GL.Vertex3(_xs[xi], _ys[yi], (float)_Z[xi, yi] + OFF);
                GL.End();
            }

            GL.LineWidth(1f);
        }

        private void DibujarEjes()
        {
            float piso = _zMin - (_zMax - _zMin) * 0.10f;
            float extH = (_xMax - _xMin) * 0.07f;
            float extV = (_zMax - _zMin) * 0.15f;

            GL.LineWidth(2f);
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(0.9f, 0.2f, 0.2f);
            GL.Vertex3(_xMin, _yMin, piso);
            GL.Vertex3(_xMax + extH, _yMin, piso);

            GL.Color3(0.2f, 0.85f, 0.2f);
            GL.Vertex3(_xMin, _yMin, piso);
            GL.Vertex3(_xMin, _yMax + extH, piso);

            GL.Color3(0.35f, 0.6f, 1.0f);
            GL.Vertex3(_xMin, _yMin, piso);
            GL.Vertex3(_xMin, _yMin, _zMax + extV);

            GL.End();
            GL.LineWidth(1f);
        }

        private void DibujarNubePuntos()
        {
            GL.PointSize(5f);
            GL.Begin(PrimitiveType.Points);
            foreach (var p in _puntos)
            {
                float t = (_zMax > _zMin)
                    ? (float)((p.Z - _zMin) / (_zMax - _zMin)) : 0.5f;
                var c = Paleta(t);
                GL.Color3(c.r, c.g, c.b);
                GL.Vertex3((float)p.X, (float)p.Y, (float)p.Z);
            }
            GL.End();
            GL.PointSize(1f);
        }

        // ============================================================
        // DIBUJO 2D ENCIMA DEL GL
        // ============================================================
        private void DibujarLeyenda(Graphics g)
        {
            if (_puntos.Count == 0) return;

            const int W = 16, H = 140;
            int x = _gl.Width - 62;
            int y = (_gl.Height - H) / 2;

            for (int i = 0; i < H; i++)
            {
                float t = 1f - (float)i / H;
                var c = Paleta(t);
                using (var pen = new Pen(Color.FromArgb(255,
                    (int)(c.r * 255), (int)(c.g * 255), (int)(c.b * 255))))
                {
                    g.DrawLine(pen, x, y + i, x + W, y + i);
                }
            }

            using (var penBorde = new Pen(Color.FromArgb(180, 255, 255, 255)))
            {
                g.DrawRectangle(penBorde, x, y, W, H);
            }

            using (var fuente = new Font("Segoe UI", 7f))
            using (var brush = new SolidBrush(Color.White))
            {
                for (int i = 0; i <= 5; i++)
                {
                    float t = (float)i / 5;
                    float zv = _zMin + t * (_zMax - _zMin);
                    int py = y + H - (int)(t * H);
                    g.DrawString($"{zv:F1}", fuente, brush, x + W + 3, py - 6);
                }

                using (var fuenteTit = new Font("Segoe UI", 7.5f, FontStyle.Bold))
                {
                    g.DrawString("Z (m)", fuenteTit, brush, x, y - 16);
                }
            }
        }

        private void DibujarAyuda(Graphics g)
        {
            using (var fuente = new Font("Segoe UI", 7f))
            using (var brush = new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
            {
                g.DrawString(
                    "Rotar: clic izq  |  Mover: clic der  |  Zoom: rueda  |  Reset: doble clic",
                    fuente, brush, 6, _gl.Height - 17);
            }
        }

        // ============================================================
        // CONSTRUCCIÓN DE LA MALLA
        // ============================================================
        private void ConstruirMalla()
        {
            _Z = null; _N = null;
            if (_puntos.Count < 3) { ActualizarBBox(); return; }

            var uxs = _puntos.Select(p => (float)p.X).Distinct().OrderBy(v => v).ToArray();
            var uys = _puntos.Select(p => (float)p.Y).Distinct().OrderBy(v => v).ToArray();

            if ((long)uxs.Length * uys.Length != _puntos.Count)
            {
                ActualizarBBox();
                return;
            }

            _xs = uxs; _ys = uys;
            int nx = _xs.Length, ny = _ys.Length;
            _Z = new double[nx, ny];

            var dic = _puntos.ToDictionary(
                p => ((float)p.X, (float)p.Y), p => p.Z);

            for (int xi = 0; xi < nx; xi++)
                for (int yi = 0; yi < ny; yi++)
                    _Z[xi, yi] = dic.TryGetValue((_xs[xi], _ys[yi]), out double z) ? z : 0;

            CalcularNormales();
            ActualizarBBox();
        }

        private void CalcularNormales()
        {
            int nx = _xs.Length, ny = _ys.Length;
            _N = new Vector3[nx, ny];

            for (int xi = 0; xi < nx - 1; xi++)
            {
                for (int yi = 0; yi < ny - 1; yi++)
                {
                    var v00 = new Vector3(_xs[xi], _ys[yi], (float)_Z[xi, yi]);
                    var v10 = new Vector3(_xs[xi + 1], _ys[yi], (float)_Z[xi + 1, yi]);
                    var v01 = new Vector3(_xs[xi], _ys[yi + 1], (float)_Z[xi, yi + 1]);
                    var n = Normalizar(Vector3.Cross(v10 - v00, v01 - v00));

                    _N[xi, yi] += n;
                    _N[xi + 1, yi] += n;
                    _N[xi, yi + 1] += n;
                    _N[xi + 1, yi + 1] += n;
                }
            }

            for (int xi = 0; xi < nx; xi++)
                for (int yi = 0; yi < ny; yi++)
                    _N[xi, yi] = Normalizar(_N[xi, yi]);
        }

        private void ActualizarBBox()
        {
            if (_puntos.Count == 0)
            {
                _cx = _cy = _cz = 0; _escala = 1;
                _xMin = _yMin = _zMin = -10;
                _xMax = _yMax = _zMax = 10;
                return;
            }

            _xMin = (float)_puntos.Min(p => p.X); _xMax = (float)_puntos.Max(p => p.X);
            _yMin = (float)_puntos.Min(p => p.Y); _yMax = (float)_puntos.Max(p => p.Y);
            _zMin = (float)_puntos.Min(p => p.Z); _zMax = (float)_puntos.Max(p => p.Z);

            if (_zMax - _zMin < 0.5f) { _zMin -= 0.5f; _zMax += 0.5f; }

            _cx = (_xMin + _xMax) / 2f;
            _cy = (_yMin + _yMax) / 2f;
            _cz = (_zMin + _zMax) / 2f;

            float span = Math.Max(Math.Max(_xMax - _xMin, _yMax - _yMin), _zMax - _zMin);
            _escala = 1.7f / Math.Max(span, 1f);
        }

        // ============================================================
        // COLOR E ILUMINACIÓN
        // ============================================================
        private static (float r, float g, float b) Paleta(float t)
        {
            t = Math.Max(0f, Math.Min(1f, t));
            float[,] s =
            {
                { 0.05f, 0.18f, 0.55f },
                { 0.05f, 0.65f, 0.75f },
                { 0.15f, 0.72f, 0.25f },
                { 0.95f, 0.85f, 0.10f },
                { 0.88f, 0.12f, 0.08f },
            };
            float seg = t * 4f;
            int i = Math.Min((int)seg, 3);
            float f = seg - i;
            return (s[i, 0] + (s[i + 1, 0] - s[i, 0]) * f,
                    s[i, 1] + (s[i + 1, 1] - s[i, 1]) * f,
                    s[i, 2] + (s[i + 1, 2] - s[i, 2]) * f);
        }

        private (float r, float g, float b) ColorConLuz(int xi, int yi)
        {
            float t = (_zMax > _zMin)
                ? ((float)_Z[xi, yi] - _zMin) / (_zMax - _zMin) : 0.5f;
            var c = Paleta(t);
            float dot = Math.Max(0f, Vector3.Dot(_N[xi, yi], LUZ));
            float fac = 0.35f + 0.65f * dot;
            return (Math.Max(0f, Math.Min(1f, c.r * fac)),
                    Math.Max(0f, Math.Min(1f, c.g * fac)),
                    Math.Max(0f, Math.Min(1f, c.b * fac)));
        }

        private static Vector3 Normalizar(Vector3 v)
        {
            float l = v.Length;
            return l > 1e-7f ? v / l : Vector3.UnitZ;
        }

        // ============================================================
        // DISPOSE
        // ============================================================
        protected override void Dispose(bool disposing)
        {
            if (disposing) _gl?.Dispose();
            base.Dispose(disposing);
        }
    }
}
