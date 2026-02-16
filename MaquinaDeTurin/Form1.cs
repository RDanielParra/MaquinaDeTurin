using System.Threading.Tasks;

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
        string simbguardado = "";
        char inicial = ' ';
        int imarca = 0;
        int direccion = 0;
        bool marcado = false;

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
        public void RehacerCinta()
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
            
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgCinta.Columns.Clear();
            dtgCinta.Rows.Clear();
            txtCompuesta.Clear();
            txtMovimientos.Clear();
            direccion = 0;
            inicial = ' ';
            imarca = 0;
            marcado = false;
            btnDesmarcar.Enabled = false;
            btnMarcar.Enabled = true;
            btnVolverAMarca.Enabled = false;
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
                //cbxEliminar1SIgual.Items.Add("Δ");
                cbxEliminarHasta.Items.Add("Δ");
                cbxEliminarSDif.Items.Add("Δ");
                //cbxEliminarSIgual.Items.Add("Δ");
                cbxEscribirSimb.Items.Add("Δ");
            }
            else
            {
                MessageBox.Show("Por favor, capture una cadena y seleccione una posición inicial.");
            }
            btnBorrarCadDer.Enabled = true;
            btnBorrarCadena.Enabled = true;
            btnBorrarCadIzq.Enabled = true;
            btnBuscarCadena.Enabled = true;
            btnBuscarDifDer.Enabled = true;
            btnBuscarDifIzq.Enabled = true;
            btnBuscarIgualDer.Enabled = true;
            btnBuscarIgualIzq.Enabled = true;
            btnCapturarCadena.Enabled = true;
            btnCopiarCad.Enabled = true;
            btnDesmarcar.Enabled = true;
            btnEliminar1SIgualDer.Enabled = true;
            btnEliminar1SIgualIzq.Enabled=true;
            btnEliminarDifDer.Enabled=true;
            btnEliminarDifIzq.Enabled=true;
            btnEliminarHastaDer.Enabled=true;
            btnEliminarHastaIzq.Enabled=true;
            btnEliminarIgualDer.Enabled=true;
            btnEliminarIgualIzq.Enabled = true;
            btnEscribirSDer.Enabled = true;
            btnEscribirSIzq.Enabled = true;
            btnGuardarS.Enabled = true;
            btnMarcar.Enabled = true;
            btnSobrescribir.Enabled = true;
            btnVolverAMarca.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moverDerecha();
            txtCompuesta.Text += "D" + "->";
            txtMovimientos.Text += "Movimiento a la Derecha" + "\r\n";
            if (marcado)
            {
                if (cabezal < imarca)
                {
                    direccion = -1;
                }
                else if (cabezal > imarca)
                {
                    direccion = 1;
                }
                else if (cabezal == imarca)
                {
                    direccion = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moverIzquierda();
            txtCompuesta.Text += "I" + "->";
            txtMovimientos.Text += "Movimiento a la Izquierda" + "\r\n";
            if (marcado)
            {
                if (cabezal < imarca)
                {
                    direccion = -1;
                }
                else if (cabezal > imarca)
                {
                    direccion = 1;
                }
                else if (cabezal == imarca)
                {
                    direccion = 0;
                }
            }
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
            /*/ Para que no se mueva el cabezal si hay terminación anormal
            bool terminacion = true;
            for(int i = cabezal; i > 0;  i--)
            {
                if (cadena[i-1].ToString() == cbxBuscarSIgual.Text)
                {
                    terminacion = false;
                }
            }
            if (terminacion)
            {
                MessageBox.Show("Terminación anormal", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /// --------------------------------------------------------- */


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
                else if (cabezal == 0) // Para mover el cabezar pero detenerse en terminación anormal
                {
                    MessageBox.Show("Terminación anormal", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                /// ------------------------------------------------------------------------------------
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
                if (cbxBuscarSIgual.Text == "Δ")
                {
                    moverDerecha();
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró " + cbxBuscarSIgual.Text.ToString() + " en la posición " + (int.Parse(cabezal.ToString()) + 1) + "\r\n";
                    return;
                }
                else
                {
                    MessageBox.Show("Problema de la parada", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            MessageBox.Show("El símbolo no se encontró a la derecha. Problema de la parada", "Cinta");
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
                if (cbxBuscarSDif.Text == "Δ")
                {
                    MessageBox.Show("No se encontró a la derecha", "Cinta");
                }
                else
                {
                    moverDerecha();
                    txtCompuesta.Text += compuesta;
                    txtMovimientos.Text += "Se encontró un símbolo diferente a " + cbxBuscarSDif.Text.ToString() + " en la posición " + cabezal.ToString() + "\r\n";
                    return;
                    //MessageBox.Show("Ya no se puede ir a la derecha", "Cinta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }
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
            MessageBox.Show("Problema de la parada", "Cinta");
        }

        private async void btnEliminarIgualIzq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxEliminarSIgual.Text))
            {
                MessageBox.Show("Seleccione un símbolo");
                return;
            }
            string simbolo = cbxEliminarSIgual.Text;
            int cont = 0;
            txtCompuesta.Text += "I." + simbolo + "->";
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;


                if (columnaActual <= dtgCinta.Columns.Count - 1)
                {
                    if (cabezal > 0)
                        cabezal--;
                    if (cabezal == 0)
                    {
                        ActualizarCinta();
                        await Task.Delay(500);
                        if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                        {
                            cont++;
                            dtgCinta.CurrentCell.Value = blanco;
                            cadena[cabezal] = char.Parse(blanco);
                            txtCompuesta.Text += blanco + "->";
                            txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        }
                        if (cont > 0)
                            MessageBox.Show("Eliminados todos los " + simbolo + " del lado izquierdo");
                        else
                            MessageBox.Show("No se borró ningun símbolo");
                        return;
                    }
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        cont++;
                        dtgCinta.CurrentCell.Value = blanco;
                        cadena[cabezal] = char.Parse(blanco);
                        txtCompuesta.Text += blanco + "->";
                        txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        txtCompuesta.Text += "I." + simbolo + "->";
                    }
                }
            }
            if (cont > 0)
            {
                MessageBox.Show("Eliminados todos los " + simbolo + " del lado derecho");
            }
            else
            {
                MessageBox.Show("No se borró ningun simbolo");
            }
        }

        private void btnEscribirSIzq_Click(object sender, EventArgs e)
        {
            /*/ Método diferente
            string simbolo = cbxEscribirSimb.Text;
            dtgCinta.CurrentCell.Value = simbolo;
            txtCompuesta.Text += simbolo + "->";
            txtMovimientos.Text += "Se escribio el simbolo " + simbolo + " en la posición " + cabezal.ToString() + "\r\n";
            moverIzquierda();
            MessageBox.Show("Simbolo " + simbolo + " escrito correctamente");
            /// ------------------------------------------------------------------------------------------------------------- */

            if (cbxEscribirSimb.Text.ToString() == "")
            {
                MessageBox.Show("Seleccione un símbolo", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cadena[cabezal] = char.Parse(cbxEscribirSimb.Text);
            RehacerCinta();
            ActualizarCinta();
            string compuesta = cbxEscribirSimb.Text.ToString() + "->";
            txtCompuesta.Text += compuesta;
            txtMovimientos.Text += "Se escribió " + cbxEscribirSimb.Text.ToString() + " en la posición " + cabezal + "\r\n";
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
            if (string.IsNullOrEmpty(cbxEliminarSIgual.Text))
            {
                MessageBox.Show("Seleccione un símbolo");
                return;
            }
            string simbolo = cbxEliminarSIgual.Text;
            int cont = 0;
            txtCompuesta.Text += "D." + simbolo + "->";
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual <= dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        cont++;
                        dtgCinta.CurrentCell.Value = blanco;
                        cadena[cabezal] = char.Parse(blanco);
                        txtCompuesta.Text += blanco + "->";
                        txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        if (cabezal < dtgCinta.Columns.Count - 1)
                        {
                            txtCompuesta.Text += "D." + simbolo + "->";
                        }
                    }
                    
                }
            }
            if (cont > 0)
            {
                MessageBox.Show("Eliminados todos los " + simbolo + " del lado derecho. Se detecto un problema de la parada al buscar más a la derecha");
            }
            else
            {
                MessageBox.Show("No se borró ningun simbolo");
            }

        }

        private async void btnEliminarDifDer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxEliminarSDif.Text))
            {
                MessageBox.Show("Seleccione un símbolo");
                return;
            }
            string simbolo = cbxEliminarSDif.Text;
            int cont = 0;
            txtCompuesta.Text += "D!" + simbolo + "->";

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
                        cadena[cabezal] = char.Parse(blanco);
                        cont++;
                        txtCompuesta.Text += blanco + "->";
                        txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        if(cabezal <  dtgCinta.Columns.Count - 1)
                        {
                            txtCompuesta.Text += "D!" + simbolo + "->";
                        }
                    }
                }
                if (columnaActual == dtgCinta.Columns.Count - 1)
                {
                    if (cont > 0)
                        MessageBox.Show("Se eliminaron los símbolos diferentes de " + simbolo + " del lado derecho. Se detecto un problema de la parada al buscar más a la derecha");
                    else
                        MessageBox.Show("No se eliminó níngun símbolo");
                    return;
                }
            }
            MessageBox.Show("Eliminados todos los simbolos diferentes de " + simbolo + " del lado derecho");
        }

        private async void btnEliminarDifIzq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxEliminarSDif.Text))
            {
                MessageBox.Show("Seleccione un símbolo");
                return;
            }
            string simbolo = cbxEliminarSDif.Text;
            int cont = 0;
            txtCompuesta.Text += "I!" + simbolo + "->";
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual <= dtgCinta.Columns.Count - 1)
                {
                    if (cabezal > 0)
                        cabezal--;
                    if (cabezal == 0)
                    {
                        ActualizarCinta();
                        await Task.Delay(500);
                        if (dtgCinta.CurrentCell.Value.ToString() != simbolo)
                        {
                            cont++;
                            dtgCinta.CurrentCell.Value = blanco;
                            cadena[cabezal] = char.Parse(blanco);
                            txtCompuesta.Text += blanco + "->";
                            txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        }
                        if (cont > 0)
                            MessageBox.Show("Eliminados todos los simbolos diferentes de  " + simbolo + " del lado izquierdo");
                        else
                            MessageBox.Show("No se borró ningún símbolo");
                        return;
                    }
                    ActualizarCinta();
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() != simbolo)
                    {
                        cont++;
                        dtgCinta.CurrentCell.Value = blanco;
                        cadena[cabezal] = char.Parse(blanco);
                        txtCompuesta.Text += blanco + "->";
                        txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        txtCompuesta.Text += "I!" + simbolo + "->";
                    }

                }
            }
            if (cont > 0)
                MessageBox.Show("Eliminados todos los símbolos diferentes de " + simbolo + " del lado izquierdo");
            else
                MessageBox.Show("No se borró ningún simbolo");
        }

        private async void btnEliminar1SIgualDer_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminar1SIgual.Text;
            while (cabezal < dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual <= dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    txtCompuesta.Text += "D->";
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                        cadena[cabezal] = char.Parse(blanco);
                        txtCompuesta.Text += blanco + "->";
                        txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        MessageBox.Show("Se elimino el primer " + simbolo + ", que se encontro en la posicion " + cabezal + " del lado Derecho");
                        return;
                    }

                }
            }
            if (cabezal == dtgCinta.Columns.Count - 1)
            {
                MessageBox.Show("Problema de la parada, no se encuentra ningún símbolo igual");
                return;
            }
        }

        private async void btnEliminar1SIgualIzq_Click(object sender, EventArgs e)
        {
            string simbolo = cbxEliminar1SIgual.Text;
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;

                if (columnaActual > 0)
                {
                    cabezal--;
                    ActualizarCinta();
                    txtCompuesta.Text += "I->";
                    await Task.Delay(500);
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        dtgCinta.CurrentCell.Value = blanco;
                        cadena[cabezal] = char.Parse(blanco);
                        txtCompuesta.Text += blanco + "->";
                        txtMovimientos.Text += "Se escribió el símbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                        MessageBox.Show("Se elimino el primer " + simbolo + ", que se encontro en la posicion " + cabezal + " del lado Izquierdo");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Terminación anormal, no se encontró ningún símbolo igual");
                    return;
                }
            }
        }

        private async void btnEliminarHastaDer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxEliminarHasta.Text))
            {
                MessageBox.Show("Seleccione un símbolo");
                return;
            }
            string simbolo = cbxEliminarHasta.Text;
            while (cabezal <= dtgCinta.Columns.Count - 1)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;
                if(cabezal == dtgCinta.Columns.Count - 1)
                {
                    MessageBox.Show("Problema de la parada");
                    return;
                }
                if (columnaActual <= dtgCinta.Columns.Count - 1)
                {
                    cabezal++;
                    ActualizarCinta();
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        MessageBox.Show("Se elimino todos los simbolos del lado derecho hasta la posicion  " + cabezal + " donde se encontre el " + simbolo);
                        return;
                    }
                    dtgCinta.CurrentCell.Value = blanco;
                    cadena[cabezal] = char.Parse(blanco);
                    txtCompuesta.Text += "D->";
                    txtCompuesta.Text += blanco + "->";
                    txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                    await Task.Delay(500);
                }
            }
        }

        private async void btnEliminarHastaIzq_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxEliminarHasta.Text))
            {
                MessageBox.Show("Seleccione un símbolo");
                return;
            }
            string simbolo = cbxEliminarHasta.Text;
            while (cabezal >= 0)
            {
                int columnaActual = dtgCinta.CurrentCell.ColumnIndex;
                if (cabezal == 0)
                {
                    MessageBox.Show("Terminación anormal");
                    return;
                }
                if (columnaActual <= dtgCinta.Columns.Count - 1)
                {
                    cabezal--;
                    ActualizarCinta();
                    if (dtgCinta.CurrentCell.Value.ToString() == simbolo)
                    {
                        MessageBox.Show("Se elimino todos los simbolos del lado derecho hasta la posicion  " + cabezal + " donde se encontre el " + simbolo);
                        return;
                    }
                    dtgCinta.CurrentCell.Value = blanco;
                    cadena[cabezal]=char.Parse(blanco);
                    txtCompuesta.Text += "I->";
                    txtCompuesta.Text += blanco + "->";
                    txtMovimientos.Text += "Se escribio el simbolo " + blanco + " en la posición " + cabezal.ToString() + "\r\n";
                    await Task.Delay(500);
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
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                tpCadena.ToolTipIcon = ToolTipIcon.Warning;
                tpCadena.ToolTipTitle = "Carácter no permitido";
                tpCadena.Show("No se permiten espacios.", txtAlfabeto, 0, -45, 2000);
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
                //cbxEliminar1SIgual.Items.Add("Δ");
                cbxEliminarHasta.Items.Add("Δ");
                cbxEliminarSDif.Items.Add("Δ");
                //cbxEliminarSIgual.Items.Add("Δ");
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
                //cbxEliminar1SIgual.Items.Add("Δ");
                cbxEliminarHasta.Items.Add("Δ");
                cbxEliminarSDif.Items.Add("Δ");
                //cbxEliminarSIgual.Items.Add("Δ");
                cbxEscribirSimb.Items.Add("Δ");
            }

        }

        private void btnGuardarS_Click(object sender, EventArgs e)
        {
            simbguardado = dtgCinta.CurrentCell.Value.ToString();
            string compuesta = simbguardado + "->}σ->";
            txtCompuesta.Text = compuesta;
        }

        private void btnSobrescribir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(simbguardado))
            {
                MessageBox.Show("No hay símbolo guardado", "Símbolo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cadena[cabezal] = char.Parse(simbguardado);
            RehacerCinta();
            ActualizarCinta();
            string compuesta = simbguardado + "->";
            txtCompuesta.Text += compuesta;
            txtMovimientos.Text += "Se sobrescribió " + simbguardado + " en la posición " + cabezal.ToString() + "\r\n";
        }

        private async void btnBorrarCadIzq_Click(object sender, EventArgs e)
        {
            if (cabezal == 0)
            {
                MessageBox.Show("Terminación anormal", "Cinta");
                return;
            }
            string compuesta = "";
            for (int i = cabezal; i >= 0; i--)
            {
                txtCompuesta.Text += "Δ->";
                if (i > 0)
                    txtCompuesta.Text += "I->";
                cadena[i] = 'Δ';
                cabezal = i;
                RehacerCinta();
                ActualizarCinta();
                await Task.Delay(500);
            }
            RehacerCinta();
            ActualizarCinta();
            txtMovimientos.Text += "Se eliminó la cadena hacia la izquierda\r\n";
        }

        private async void btnBorrarCadDer_Click(object sender, EventArgs e)
        {
            if (cabezal == cadena.Length - 1)
            {
                MessageBox.Show("No se puede ir a la derecha", "Cinta");
                return;
            }
            string compuesta = "";
            for (int i = cabezal; i <= cadena.Length - 1; i++)
            {
                txtCompuesta.Text += "Δ->";
                if (i < cadena.Length - 1)
                    txtCompuesta.Text += "D->";
                cadena[i] = 'Δ';
                cabezal = i;
                RehacerCinta();
                ActualizarCinta();
                await Task.Delay(500);
            }
            RehacerCinta();
            ActualizarCinta();
            txtMovimientos.Text += "Se eliminó la cadena hacia la derecha\r\n";
        }

        private async void btnBorrarCadena_Click(object sender, EventArgs e)
        {
            inicial = cadena[cabezal];
            imarca = cabezal;
            cadena[cabezal] = '*';
            dtgCinta.CurrentCell.Value = '*';
            txtCompuesta.Text += "*->";
            if (cabezal != 0)
            {

                for (int i = cabezal - 1; i >= 0; i--)
                {

                    cabezal--;
                    txtCompuesta.Text += "I->";
                    txtCompuesta.Text += blanco + "->";
                    cadena[i] = char.Parse(blanco);
                    ActualizarCinta();
                    dtgCinta.CurrentCell.Value = blanco;
                    await Task.Delay(500);
                }
                txtCompuesta.Text += "D.*->";
                cabezal++;
                ActualizarCinta();
                await Task.Delay(500);
            }
            for (int i = cabezal + 1; i <= cadena.Length - 1; i++)
            {
                if (cabezal >= imarca)
                {
                    cabezal++;
                    txtCompuesta.Text += "D->";
                }
                else
                {
                    cabezal++;
                }
                ActualizarCinta();

                if (cadena[i] != '*' && cadena[i] != char.Parse(blanco))
                {
                    cadena[i] = char.Parse(blanco);
                    ActualizarCinta();
                    dtgCinta.CurrentCell.Value = blanco;
                    txtCompuesta.Text += blanco + "->";
                }
                else if (cadena[i] == '*' && cabezal == cadena.Length - 1)
                {
                    cadena[i] = char.Parse(blanco);
                    ActualizarCinta();
                    dtgCinta.CurrentCell.Value = blanco;
                    txtCompuesta.Text += blanco + "->";
                    txtMovimientos.Text += "Se eliminaron todos los símbolos de la cadena\r\n";
                    MessageBox.Show("Se borró la cadena");
                    inicial = ' ';
                    imarca = 0;
                    return;
                }

                ActualizarCinta();
                await Task.Delay(500);
            }
            txtCompuesta.Text += "I.*->";
            for (int i = cabezal - 1; i >= 0; i--)
            {
                cabezal--;
                ActualizarCinta();
                if (cadena[i] == '*')
                {
                    cadena[i] = char.Parse(blanco);
                    ActualizarCinta();
                    dtgCinta.CurrentCell.Value = blanco;
                    txtCompuesta.Text += blanco + "->";
                    txtMovimientos.Text += "Se eliminaron todos los símbolos de la cadena\r\n";
                    MessageBox.Show("Se borró la cadena");
                    inicial = ' ';
                    imarca = 0;
                    return;
                }
                await Task.Delay(500);
            }
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            inicial = cadena[cabezal];
            dtgCinta.CurrentCell.Value = '*';
            imarca = cabezal;
            txtCompuesta.Text += "*->";
            txtMovimientos.Text += "Se marcó la cinta con * en la posición" + cabezal + "\r\n";
            marcado = true;
            btnMarcar.Enabled = false;
            btnDesmarcar.Enabled = true;
            btnVolverAMarca.Enabled = true;
        }

        private async void btnVolverAMarca_Click(object sender, EventArgs e)
        {
            if (direccion == 0 || imarca == cabezal)
            {
                MessageBox.Show("Ya se encuentra en la marca");
                return;
            }
            else if (direccion == 1)
            {
                txtCompuesta.Text += "I.*->";
                for (int i = cabezal - 1; i > imarca; i--)
                {
                    cabezal--;
                    ActualizarCinta();
                    await Task.Delay(500);
                }
                cabezal--;
                ActualizarCinta();
                txtMovimientos.Text += "El cabezal regreso a la posición" + cabezal + " marcada con *\r\n";
                MessageBox.Show("El cabezal regreso a la marca *");
                return;
            }
            else if (direccion == -1)
            {
                txtCompuesta.Text += "D.*->";
                for (int i = cabezal + 1; i < imarca; i++)
                {
                    cabezal++;
                    ActualizarCinta();
                    await Task.Delay(500);
                }
                cabezal++;
                ActualizarCinta();
                txtMovimientos.Text += "El cabezal regreso a la posición" + cabezal + " marcada con *\r\n";
                MessageBox.Show("El cabezal regreso a la marca *");
                return;
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            if (marcado)
            {
                if(dtgCinta.CurrentCell.Value.ToString() == "*")
                {
                    dtgCinta.CurrentCell.Value = cadena[cabezal].ToString();
                    txtCompuesta.Text += cadena[cabezal] + "->";
                    txtMovimientos.Text += "Se desmarcó la cinta y se escribió " + cadena[cabezal];
                    MessageBox.Show("Cinta desmarcada");
                    imarca = 0;
                    marcado = false;
                    btnMarcar.Enabled = true;
                    btnDesmarcar.Enabled = false;
                    inicial = ' ';
                    btnVolverAMarca.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("La posición actual no está marcada");
                }
            }
            else
            {
                MessageBox.Show("Primero tiene que marcar la cinta");
            }
        }
    }
}
