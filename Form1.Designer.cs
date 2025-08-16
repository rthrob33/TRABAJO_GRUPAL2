namespace TodoList
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxTarea = new TextBox();
            cbPrioridad = new ComboBox();
            btnAgregar = new Button();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            lblTarea = new Label();
            lblPrioridad = new Label();
            flowPanelTodoList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtBoxTarea
            // 
            txtBoxTarea.Location = new Point(63, 76);
            txtBoxTarea.Margin = new Padding(4);
            txtBoxTarea.Name = "txtBoxTarea";
            txtBoxTarea.PlaceholderText = "Indique el nombre de su tarea";
            txtBoxTarea.Size = new Size(823, 35);
            txtBoxTarea.TabIndex = 0;
            // 
            // cbPrioridad
            // 
            cbPrioridad.FormattingEnabled = true;
            cbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cbPrioridad.Location = new Point(924, 78);
            cbPrioridad.Margin = new Padding(4);
            cbPrioridad.Name = "cbPrioridad";
            cbPrioridad.Size = new Size(278, 38);
            cbPrioridad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1234, 76);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 44);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += onBtnAgregarClick;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(926, 176);
            txtBoxBuscar.Margin = new Padding(4);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Nombre de la tarea ...";
            txtBoxBuscar.Size = new Size(278, 35);
            txtBoxBuscar.TabIndex = 3;
            txtBoxBuscar.TextChanged += txtBoxBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1236, 176);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 44);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += txtBoxBuscar_TextChanged;
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(72, 51);
            lblTarea.Margin = new Padding(4, 0, 4, 0);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(62, 30);
            lblTarea.TabIndex = 5;
            lblTarea.Text = "Tarea";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(934, 51);
            lblPrioridad.Margin = new Padding(4, 0, 4, 0);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(96, 30);
            lblPrioridad.TabIndex = 6;
            lblPrioridad.Text = "Prioridad";
            // 
            // flowPanelTodoList
            // 
            flowPanelTodoList.Location = new Point(42, 234);
            flowPanelTodoList.Margin = new Padding(4);
            flowPanelTodoList.Name = "flowPanelTodoList";
            flowPanelTodoList.Size = new Size(1317, 579);
            flowPanelTodoList.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 844);
            Controls.Add(flowPanelTodoList);
            Controls.Add(lblPrioridad);
            Controls.Add(lblTarea);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(cbPrioridad);
            Controls.Add(txtBoxTarea);
            Margin = new Padding(4);
            Name = "Form1";
            Padding = new Padding(9);
            Text = "Control de Tareas";
            Click += onBtnAgregarClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxTarea;
		private ComboBox cbPrioridad;
		private Button btnAgregar;
		private TextBox txtBoxBuscar;
		private Button btnBuscar;
		private Label lblTarea;
		private Label lblPrioridad;
		private FlowLayoutPanel flowPanelTodoList;
	}
}
