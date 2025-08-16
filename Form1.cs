using TodoList.Clases;

namespace TodoList
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        public void onBtnAgregarClick(object sender, EventArgs e)
        {
            string nombreTarea = txtBoxTarea.Text;
            string prioridadSeleccionada = cbPrioridad.SelectedItem.ToString();
            Prioridad prioridadTarea;
            switch (prioridadSeleccionada)
            {
                case "Alta":
                    prioridadTarea = Prioridad.Alta;
                    break;
                case "Media":
                    prioridadTarea = Prioridad.Media;
                    break;
                default:
                    prioridadTarea = Prioridad.Baja;
                    break;

            }

            Tarea nuevaTarea = new Tarea { Nombre = nombreTarea, Prioridad = prioridadTarea };

            tareas.Add(nuevaTarea);

            txtBoxTarea.Text = "";
            cbPrioridad.ResetText();

            renderizarTareas();
        }

        public void renderizarTareas()
        {
            flowPanelTodoList.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                Panel tarjeta = crearTarjeta(tarea);
                flowPanelTodoList.Controls.Add(tarjeta);
            }
        }

        public Panel crearTarjeta(Tarea tarea)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 100);
            tarjeta.Padding = new Padding(5);
            tarjeta.Margin = new Padding(5);
            tarjeta.BackColor = Color.White;
            tarjeta.Tag = tarea;

            Label nombreTarea = new Label();
            nombreTarea.AutoSize = true;
            nombreTarea.Text = $"{tarea.Nombre}";
            nombreTarea.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            nombreTarea.Dock = DockStyle.Top;
            nombreTarea.Margin = new Padding(3, 3, 3, 3);

            Label prioridad = new Label();
            prioridad.AutoSize = true;
            prioridad.Text = tarea.Prioridad.ToString();
            prioridad.Font = new Font("Segoe UI", 9);
            prioridad.Dock = DockStyle.Top;
            prioridad.Margin = new Padding(3, 50, 3, 3);


            switch (tarea.Prioridad)
            {
                case Prioridad.Alta:
                    prioridad.ForeColor = Color.Red;
                    break;
                case Prioridad.Media:
                    prioridad.ForeColor = Color.Orange;
                    break;
                default: // Baja
                    prioridad.ForeColor = Color.Green;
                    break;
            }

            tarjeta.Controls.Add(prioridad);
            tarjeta.Controls.Add(nombreTarea);

            return tarjeta;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBoxBuscar.Text.ToLower();
            flowPanelTodoList.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                if (tarea.Nombre.ToLower().Contains(textoBusqueda))
                {
                    Panel tarjeta = crearTarjeta(tarea);
                    flowPanelTodoList.Controls.Add(tarjeta);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbPrioridad.Items.Add("Alta");
            cbPrioridad.Items.Add("Media");
            cbPrioridad.Items.Add("Baja");
            cbPrioridad.SelectedIndex = 0; // Selecciona "Baja" por defecto
        }
    }
}
