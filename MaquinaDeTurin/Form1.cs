namespace MaquinaDeTurin
{
    public partial class Form1 : Form
    {
        int[] alfabeto;
        char[] cadena;
        char[] separacion = ['Δ'];
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
                //MessageBox.Show("Has llegado al final de la cinta (Derecha).");
                cadena = cadena.Concat(separacion).ToArray();

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
                    cabezal++;
                    dtgCinta.Focus();

                    dtgCinta.CurrentCell = dtgCinta.Rows[0].Cells[cabezal];

                    dtgCinta.CurrentCell.Style.BackColor = Color.Yellow;
                    dtgCinta.CurrentCell.Style.SelectionBackColor = Color.Orange;

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
            alfabeto = alfabetoChar.Select(c => (int)c).ToArray();
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
            cbxPosicionIni.Focus();
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

        private async void btnBuscarIgualIzq_Click(object sender, EventArgs e)
        {

            if (cbxBuscarSIgual.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabezal == 0)
            {
                MessageBox.Show("Ya no se puede ir a la izquierda, Terminacion Anormal", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "I" + subindice + cbxBuscarSIgual.Text.ToString() + "->";
            while (cabezal >= 0)
            {
                cabezal--;
                ActualizarCinta();
                await Task.Delay(500);
                if (cbxBuscarSIgual.Text == cadena[cabezal].ToString())
                {
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró " + cbxBuscarSIgual.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    return;
                }
            }
            MessageBox.Show("El símbolo no se encontró a la izquierda", "Cinta");


        }

        private async void btnBuscarIgualDer_Click(object sender, EventArgs e)
        {
            if (cbxBuscarSIgual.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "D" + subindice + cbxBuscarSIgual.Text.ToString() + "->";
            if (cabezal == cadena.Length - 1)
            {
                txtCompuesta.Text += compuesta;
                txtMovimientos.Text += "Se encontró " + cbxBuscarSIgual.Text.ToString() + " en la posición " + (int.Parse(cabezal.ToString()) + 1) + "\r\n";
                return;
                //MessageBox.Show("Ya no se puede ir a la derecha", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                cabezal++;
                ActualizarCinta();
                await Task.Delay(500);
                if (cbxBuscarSIgual.Text == cadena[cabezal].ToString())
                {
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró " + cbxBuscarSIgual.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    return;
                }
            }
            MessageBox.Show("El símbolo no se encontró a la derecha", "Cinta");
        }

        private async void btnBuscarDifIzq_Click(object sender, EventArgs e)
        {
            if (cbxBuscarSDif.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabezal <= 0)
            {
                MessageBox.Show("Ya no se puede ir a la izquierda, Terminacion Anormal", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "I" + diferente + cbxBuscarSDif.Text.ToString() + "->";
            while (cabezal >= 0)
            {
                cabezal--;
                ActualizarCinta();
                await Task.Delay(500);
                if (cbxBuscarSDif.Text != cadena[cabezal].ToString())
                {
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró un símbolo diferente a " + cbxBuscarSDif.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    return;
                }
            }
            MessageBox.Show("No se encontró a la izquierda", "Cinta");

        }

        private async void btnBuscarDifDer_Click(object sender, EventArgs e)
        {
            if (cbxBuscarSDif.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string compuesta = "D" + diferente + cbxBuscarSDif.Text.ToString() + "->";
            if (cabezal == cadena.Length - 1)
            {
                txtCompuesta.Text += compuesta;
                txtMovimientos.Text += "Se encontró " + blanco + " en la posición " + (int.Parse(cabezal.ToString()) + 1) + "\r\n";
                return;
                //MessageBox.Show("Ya no se puede ir a la derecha", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                cabezal++;
                ActualizarCinta();
                await Task.Delay(500);
                if (cbxBuscarSDif.Text != cadena[cabezal].ToString())
                {
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró un símbolo diferente a " + cbxBuscarSDif.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    return;
                }
            }
            MessageBox.Show("No se encontró a la derecha", "Cinta");
        }

        private async void btnEliminarIgualIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSIgual.Text;
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    if (cabezal-- < 0)
                    {
                        return;
                    }
                    cabezal--;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }
                }
            }
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

        private async void btnEliminarIgualDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }
                }
            }
            MessageBox.Show("Eliminados todos los " + simbolo + " del lado derecho");

        }

        private async void btnEliminarDifDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSDif.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() != simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }
                }
            }
            MessageBox.Show("Eliminados todos los diferentes de " + simbolo + " del lado derecho");
        }

        private async void btnEliminarDifIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarSDif.Text;
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal--;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() != simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                    }

                }
            }
            MessageBox.Show("Eliminados todos los diferentes de " + simbolo + " del lado izquierdo");
        }

        private async void btnEliminar1SIgualDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminar1SIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                        MessageBox.Show("Se elimino el primer " + simbolo + ", que se encontro en la posicion " + cabezal + " del lado Derecho");
                        return;
                    }

                }
            }
        }

        private async void btnEliminar1SIgualIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminar1SIgual.Text;
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal--;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                        MessageBox.Show("Se elimino el primer " + simbolo + ", que se encontro en la posicion " + cabezal + " del lado Izquierdo");
                        return;
                    }

                }
            }
        }

        private async void btnEliminarHastaDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarHasta.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    dtgCinta.CurrentCell.Value = blanco;
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        MessageBox.Show("Se elimino todos los simbolos del lado derecho hasta la posicion  " + cabezal + " donde se encontre el " + simbolo);
                        return;
                    }

                }
            }
        }

        private async void btnEliminarHastaIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminarHasta.Text;
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual < dtgCinta.Columns.Count - 1)
                {
                    cabezal--;
                    ActualizarCinta();
                    dtgCinta.CurrentCell.Value = blanco;
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        MessageBox.Show("Se elimino todos los simbolos del lado derecho hasta la posicion  " + cabezal + " donde se encontre el " + simbolo);
                        return;
                    }

                }
            }
        }

        private void btnBuscarCadena_Click(object sender, EventArgs e)
        {

            char[] cadena;
            cadena = txtBuscarCadena.Text.ToCharArray();
            char[] cadenainv = cadena;
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < cadena.Length; j++)
                {
                    cadenainv[j] = cadena[i];
                }
            }

            if (radBuscarCadIzq.Checked == true)
            {
                //validar si se encuentran los limites
                //llamar la funcion en caso de que si se pueda buscar
                //si es true volver a buscar el siguiente mandando el char que sigue
                //dowhile
                //si es false empezar desde el primer char otra vez
                for (int i = 0; i < cadenainv.Length; i++)
                {
                    if (cabezal == 0)
                    {
                        MessageBox.Show("Ya no se puede ir a la izquierda, no se encontro", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (BuscarIzq(cadenainv[i]) != true)
                    {
                        i = 0;
                    }
                }
            }
            else if (radBuscarCadDer.Checked == true)
            {

            }
        }

        private void txtBuscarCadena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                int cursor = txtBuscarCadena.SelectionStart;
                txtBuscarCadena.Text = txtBuscarCadena.Text.Insert(cursor, blanco);
                txtBuscarCadena.SelectionStart = cursor + 1;
                return;
            }

            if (alfabeto.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                tpCadena.Hide(txtBuscarCadena);
            }
            else
            {
                e.Handled = true;
                tpCadena.ToolTipIcon = ToolTipIcon.Warning;
                tpCadena.ToolTipTitle = "Carácter no permitido";
                tpCadena.Show("Solo se permiten los símbolos exactos del alfabeto.", txtBuscarCadena, 0, -45, 2000);
            }
        }

        private bool BuscarIzq(char simboloBuscar)
        {
            string compuesta = "I" + subindice + simboloBuscar.ToString() + "->";
            for (int i = cabezal; i > 0; i--)
            {

                if (simboloBuscar.ToString() == cadena[i - 1].ToString())
                {
                    cabezal = i - 1;
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró " + simboloBuscar.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    ActualizarCinta();
                    return true;
                }

            }
            return false;
        }

        private void txtAlfabeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (txtAlfabeto.Text.ToLower().Contains(char.ToLower(e.KeyChar)))
            {
                e.Handled = true;
                tpCadena.ToolTipIcon = ToolTipIcon.Warning;
                tpCadena.ToolTipTitle = "Carácter no permitido";
                tpCadena.Show("No se pueden repetir caracteres.", txtAlfabeto, 0, -45, 2000);
            }
        }

        private void btnCopiarCad_Click(object sender, EventArgs e)
        {

            cadena = cadena.Concat(separacion).Concat(cadena).ToArray();

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
                MessageBox.Show("Cadena copiada.");

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] cadenainv = (char[])cadena.Clone();
            Array.Reverse(cadenainv);

            cadena = cadena.Concat(separacion).Concat(cadenainv).ToArray();

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
                MessageBox.Show("Cadena copiada.");

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

        }
    }
}
