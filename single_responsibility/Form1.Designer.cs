namespace single_responsibility
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
            lblName = new Label();
            lblPosition = new Label();
            lblHourlySalary = new Label();
            txtName = new TextBox();
            txtPosition = new TextBox();
            txtHourlySalary = new TextBox();
            btnCreateEmployee = new Button();
            dataGridViewEmployees = new DataGridView();
            label1 = new Label();
            txtHoursWorked = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ingrese nombre";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(12, 54);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(191, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Ingrese posicion que ocupa";
            // 
            // lblHourlySalary
            // 
            lblHourlySalary.AutoSize = true;
            lblHourlySalary.Location = new Point(12, 97);
            lblHourlySalary.Name = "lblHourlySalary";
            lblHourlySalary.Size = new Size(248, 20);
            lblHourlySalary.TabIndex = 2;
            lblHourlySalary.Text = "Ingrese el salario que gana por hora";
            // 
            // txtName
            // 
            txtName.Location = new Point(336, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(327, 27);
            txtName.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(336, 51);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(327, 27);
            txtPosition.TabIndex = 4;
            // 
            // txtHourlySalary
            // 
            txtHourlySalary.Location = new Point(336, 97);
            txtHourlySalary.Name = "txtHourlySalary";
            txtHourlySalary.Size = new Size(327, 27);
            txtHourlySalary.TabIndex = 5;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(569, 201);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(94, 29);
            btnCreateEmployee.TabIndex = 6;
            btnCreateEmployee.Text = "Crear empleado";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 236);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.Size = new Size(651, 286);
            dataGridViewEmployees.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese la cantidad de horas trabajadas";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(336, 140);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(327, 27);
            txtHoursWorked.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 534);
            Controls.Add(txtHoursWorked);
            Controls.Add(label1);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(btnCreateEmployee);
            Controls.Add(txtHourlySalary);
            Controls.Add(txtPosition);
            Controls.Add(txtName);
            Controls.Add(lblHourlySalary);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPosition;
        private Label lblHourlySalary;
        private TextBox txtName;
        private TextBox txtPosition;
        private TextBox txtHourlySalary;
        private Button btnCreateEmployee;
        private DataGridView dataGridViewEmployees;
        private Label label1;
        private TextBox txtHoursWorked;
    }
}
