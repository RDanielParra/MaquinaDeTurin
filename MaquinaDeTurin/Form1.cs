namespace MaquinaDeTurin
{
    public partial class Form1 : Form
    {
        int[] alfabeto;
        char[] cadena;
        int cabezal;
        string subindice = ".";
        string diferente = "!";
        string blanco = "Δ";

        public void moverIzquierda()
        {
            int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

            if (columnaActual > 0)
            {
                dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual - 1];
                dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
                dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
                cabezal--;
            }
            else
            {
                MessageBox.Show("Has llegado al inicio de la cinta (Izquierda).");
            }
        }

        public void moverDerecha()
        {
            int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

            if (columnaActual < dtgCinta.Columns.Count - 1)
            {
                dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual + 1];
                dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
                dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
                cabezal++;
            }
            else
            {
                MessageBox.Show("Has llegado al final de la cinta (Derecha).");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Limpiarcbx()
        {
            cbxBuscarSIgual.Items.Clear();
            cbxBuscarSDif.Items.Clear();
            cbxEliminar1SIgual.Items.Clear();
            cbxEliminarHasta.Items.Clear();
            cbxEliminarSDif.Items.Clear();
            cbxEliminarSIgual.Items.Clear();
            cbxEscribirSimb.Items.Clear();
        }

        public void ActualizarCinta()
        {
            dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
            dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
            dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[cabezal];
            dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
            dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
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
                e.Handled = true;
                int cursor = txtCadena.SelectionStart;
                txtCadena.Text = txtCadena.Text.Insert(cursor, blanco);
                txtCadena.SelectionStart = cursor + 1;
                return;
            }

            if (alfabeto.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                tpCadena.Hide(txtCadena);
            }
            else
            {
                e.Handled = true;
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
            txtCompuesta.Clear();
            txtMovimientos.Clear();

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

                Limpiarcbx();
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    cbxBuscarSIgual.Items.Add((char)alfabeto[i]);
                    cbxBuscarSDif.Items.Add((char)alfabeto[i]);
                    cbxEliminar1SIgual.Items.Add((char)alfabeto[i]);
                    cbxEliminarHasta.Items.Add((char)alfabeto[i]);
                    cbxEliminarSDif.Items.Add((char)alfabeto[i]);
                    cbxEliminarSIgual.Items.Add((char)alfabeto[i]);
                    cbxEscribirSimb.Items.Add((char)alfabeto[i]);
                }
                cbxBuscarSIgual.Items.Add("Δ");
                cbxBuscarSDif.Items.Add("Δ");
                cbxEliminar1SIgual.Items.Add("Δ");
                cbxEliminarHasta.Items.Add("Δ");
                cbxEliminarSDif.Items.Add("Δ");
                cbxEliminarSIgual.Items.Add("Δ");
                cbxEscribirSimb.Items.Add("Δ");
            }
            else
            {
                MessageBox.Show("Por favor, capture una cadena y seleccione una posición inicial.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moverDerecha();
            txtCompuesta.Text += "D" + "->";
            txtMovimientos.Text += "Movimiento a la Derecha" + "\r\n";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            moverIzquierda();
            txtCompuesta.Text += "I" + "->";
            txtMovimientos.Text += "Movimiento a la Izquierda" + "\r\n";

        }

        private void btnBuscarIgualIzq_Click(object sender, EventArgs e)
        {

            if (cbxBuscarSIgual.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabezal == 0)
            {
                MessageBox.Show("Ya no se puede ir a la izquierda", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "I" + subindice + cbxBuscarSIgual.Text.ToString() + "->";
            for (int i = cabezal; i > 0; i--)
            {

                if (cbxBuscarSIgual.Text == cadena[i - 1].ToString())
                {
                    cabezal = i - 1;
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró " + cbxBuscarSIgual.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    ActualizarCinta();
                    break;
                }
                if (i - 1 == 0)
                {
                    MessageBox.Show("El símbolo no se encontró a la izquierda", "Cinta");
                }
            }

        }

        private void btnBuscarIgualDer_Click(object sender, EventArgs e)
        {
            if (cbxBuscarSIgual.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabezal == cadena.Length - 1)
            {
                MessageBox.Show("Ya no se puede ir a la derecha", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "D" + subindice + cbxBuscarSIgual.Text.ToString() + "->";
            for (int i = cabezal; i < cadena.Length - 1; i++)
            {

                if (cbxBuscarSIgual.Text == cadena[i + 1].ToString())
                {
                    cabezal = i + 1;
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró " + cbxBuscarSIgual.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    ActualizarCinta();
                    break;
                }
                if (i + 1 == cadena.Length - 1)
                {
                    MessageBox.Show("El símbolo no se encontró a la derecha", "Cinta");
                }
            }
        }

        private void btnBuscarDifIzq_Click(object sender, EventArgs e)
        {
            if (cbxBuscarSDif.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabezal == 0)
            {
                MessageBox.Show("Ya no se puede ir a la izquierda", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "I" + diferente + cbxBuscarSDif.Text.ToString() + "->";
            for (int i = cabezal; i > 0; i--)
            {

                if (cbxBuscarSDif.Text != cadena[i - 1].ToString())
                {
                    cabezal = i - 1;
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró un símbolo diferente a " + cbxBuscarSDif.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    ActualizarCinta();
                    break;
                }
                if (i - 1 == 0)
                {
                    MessageBox.Show("No se encontró a la izquierda", "Cinta");
                }
            }
        }

        private void btnBuscarDifDer_Click(object sender, EventArgs e)
        {
            if (cbxBuscarSDif.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabezal == cadena.Length - 1)
            {
                MessageBox.Show("Ya no se puede ir a la derecha", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "D" + diferente + cbxBuscarSDif.Text.ToString() + "->";
            for (int i = cabezal; i < cadena.Length - 1; i++)
            {

                if (cbxBuscarSDif.Text != cadena[i + 1].ToString())
                {
                    cabezal = i + 1;
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró un símbolo diferente a " + cbxBuscarSDif.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    ActualizarCinta();
                    break;
                }
                if (i + 1 == cadena.Length - 1)
                {
                    MessageBox.Show("No se encontró a la derecha", "Cinta");
                }
            }
        }

        private void btnEliminarIgualIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual - 1];
                    if (dtgCinta.CurrentCell.Value == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }
                    cabezal--;
                }
            }
            dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
            dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
            MessageBox.Show("Eliminados todos los " + simbolo + " del lado izquierdo");
        }

        private void btnEscribirSIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEscribirSimb.Text;
            dtgCinta.CurrentCell.Value = simbolo;
            txtCompuesta.Text += simbolo + "->";
            txtMovimientos.Text += "Se escribio el simbolo " + simbolo + " en la posición " + cabezal.ToString() + "\r\n";
            moverIzquierda();
            MessageBox.Show("Simbolo " + simbolo + " escrito correctamente");

        }

        private void btnEscribirSDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEscribirSimb.Text;
            dtgCinta.CurrentCell.Value = simbolo;
            txtCompuesta.Text += simbolo + "->";
            txtMovimientos.Text += "Se escribio el simbolo " + simbolo + " en la posición " + cabezal.ToString() + "\r\n";
            moverDerecha();
            MessageBox.Show("Simbolo " + simbolo + " escrito correctamente");
        }

        private void btnEliminarIgualDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual + 1];
                    if (dtgCinta.CurrentCell.Value == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }
                    cabezal++;
                }
            }
            dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
            dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
            MessageBox.Show("Eliminados todos los " + simbolo + " del lado derecho");

        }

        private void btnEliminarDifDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSDif.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual + 1];
                    if (dtgCinta.CurrentCell.Value != simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }
                    cabezal++;
                }
            }
            dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
            dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
            MessageBox.Show("Eliminados todos los diferentes de " + simbolo + " del lado derecho");
        }

        private void btnEliminarDifIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSDif.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual - 1];
                    if (dtgCinta.CurrentCell.Value != simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }

                    cabezal--;
                }
            }
            dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
            dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;
            MessageBox.Show("Eliminados todos los " + simbolo + " del lado izquierdo");
        }

        private void btnEliminar1SIgualDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminar1SIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual + 1];

                    if (dtgCinta.CurrentCell.Value == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                        break;
                    }

                }
            }
            MessageBox.Show("Solo 1, en la pos " + cabezal);
        }

        private void btnEliminar1SIgualIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminar1SIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal--;
                    dtgCinta.CurrentCell.Style.BackColor = Color.Empty;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Empty;
                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[columnaActual - 1];

                    if (dtgCinta.CurrentCell.Value == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                        break;
                    }

                }
            }
            MessageBox.Show("Solo 1, en la pos " + cabezal);
        }
    }
}
