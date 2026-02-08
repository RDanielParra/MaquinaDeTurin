namespace MaquinaDeTurin
{
    public partial class Form1 : Form
    {
        int[] alfabeto;
        char[] cadena;
        int cabezal;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCadena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadena_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnAlfabeto_Click(object sender, EventArgs e)
        {
            string alfabetoCadena = txtAlfabeto.Text;
            char[] alfabetoChar = alfabetoCadena.ToCharArray();
            alfabeto = alfabetoChar.Select(c => (int)char.ToUpper(c)).ToArray();
            txtCadena.Enabled = true;
            btnCapturarCadena.Enabled = true;
            MessageBox.Show("Alfabeto capturado correctamente!");

        }

        private void txtCadena_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Bloquea el espacio
                int cursor = txtCadena.SelectionStart;
                txtCadena.Text = txtCadena.Text.Insert(cursor, "Δ");
                txtCadena.SelectionStart = cursor + 1;
                return;
            }

            // El evento KeyPress distingue automáticamente entre 'a' y 'A'
            if (alfabeto.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                tpCadena.Hide(txtCadena);
            }
            else
            {
                e.Handled = true; // Bloquea el carácter si no está en el array exacto
                tpCadena.ToolTipIcon = ToolTipIcon.Warning;
                tpCadena.ToolTipTitle = "Carácter no permitido";
                tpCadena.Show("Solo se permiten los símbolos exactos del alfabeto.", txtCadena, 0, -45, 2000);
            }
        }

        private void btnCapturarCadena_Click(object sender, EventArgs e)
        {
            cadena = txtCadena.Text.ToCharArray();
            cbxPosicionIni.Items.Clear();

            for (int i = 0; i < cadena.Length; i++)
            {
                cbxPosicionIni.Items.Add(i);
            }
            MessageBox.Show("Cadena capturada correctamente!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgCinta.Columns.Clear();
            dtgCinta.Rows.Clear();

            for (int i = 0; i < cadena.Length; i++)
            {
                dtgCinta.Columns.Add("Col" + i, i.ToString());

                dtgCinta.Columns[i].Width = 40;
            }
            object[] filaEstructurada = cadena.Select(c => c.ToString()).ToArray();
            dtgCinta.Rows.Add(filaEstructurada);

            if (cbxPosicionIni.SelectedItem != null)
            {
                cabezal = int.Parse(cbxPosicionIni.SelectedItem.ToString());

                dtgCinta.Focus();

                dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[cabezal];

                dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
                dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
                MessageBox.Show("Maquina de Turing encendida.");
            }
            else
            {
                MessageBox.Show("Por favor, capture una cadena y seleccione una posición inicial.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

            if (columnaActual < dtgCinta.Columns.Count - 1)
            {
                dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual + 1];
                cabezal++;
            }
            else
            {
                MessageBox.Show("Has llegado al final de la cinta (Derecha).");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

            if (columnaActual > 0)
            {
                dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual - 1];
                cabezal--;
            }
            else
            {
                MessageBox.Show("Has llegado al inicio de la cinta (Izquierda).");
            }
        }
    }
}
