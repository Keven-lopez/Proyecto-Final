using Proyecto_Final.Resources.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        private League league;
        private PrivateFontCollection privateFontCollection;
        SoundPlayer player = new SoundPlayer("C:\\Users\\ded5t\\source\\repos\\Proyecto Final\\Proyecto Final\\Resources\\league_button.wav");
        private bool allowChange = false;
        private bool modo = false;
        private string[] regions =
        {
            "Bandle City",
            "Bilgewater",
            "Demacia",
            "Ionia",
            "Ixtal",
            "Noxus",
            "Piltover",
            "Shadow Isles",
            "Shurima",
            "Targon",
            "Freljord",
            "The Void",
            "Zaun"
        };
        private string[] sexo =
        {
            "M",
            "F"
        };
        private string[] roles =
        {
            "Top",
            "Mid",
            "Bot",
            "Jgl",
            "Sup"
        };
        private string[] alcance = {
            "Melee",
            "Distancia"
        };
        private string[] danio = {
            "Fisico",
            "Magico"
        };

        private void LoadCustomFont()
        {

            privateFontCollection = new PrivateFontCollection();

            string fontPath1 = System.IO.Path.Combine(Application.StartupPath, "C:\\Users\\ded5t\\source\\repos\\Proyecto Final\\Proyecto Final\\Resources\\BeaufortforLOL-Bold.otf");
            string fontPath2 = System.IO.Path.Combine(Application.StartupPath, "C:\\Users\\ded5t\\source\\repos\\Proyecto Final\\Proyecto Final\\Resources\\Spiegel-Bold.otf");

            privateFontCollection.AddFontFile(fontPath1);
            privateFontCollection.AddFontFile(fontPath2);


        }

        private void ApplyCustomFont(Control control)
        {
            Font customFont1 = new Font(privateFontCollection.Families[0], 40f);
            Font customFont2 = new Font(privateFontCollection.Families[0], 18f);
            Font customFont3 = new Font(privateFontCollection.Families[1], 15f);
            Font customFont4 = new Font(privateFontCollection.Families[0], 13f);

            foreach (Control childControl in control.Controls)
            {
                if (childControl is Label label)
                {
                    label.Font = customFont2;
                }
                else if (childControl is TextBox textBox)
                {
                    textBox.Font = customFont2;
                }
                else if (childControl is CheckedListBox checkedList)
                {
                    checkedList.Font = customFont2;
                }
                else if (childControl is ComboBox combo)
                {
                    combo.Font = customFont2;
                }
                else if (childControl is Button button)
                {
                    button.Font = customFont4;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
            }

            label1.Location = new Point(400, 36);
            label1.Font = customFont1;
            labelModo.Font = customFont3;
            dataGridView1.Font = customFont3;
            dataGridView1.Size = new Size(1140, 222);
            dataGridView1.Location = new Point(210, 540);


        }


        public Form1()
        {
            InitializeComponent();
            LoadCustomFont();
            ApplyCustomFont(this);
            league = new League();
        }


        private void LoadTable()
        {
            DataTable dt = league.ActualizarTabla();
            dataGridView1.DataSource = dt;
        }

        private void Erase(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox textBox)
                {
                    textBox.Text = " ";
                }
                else if (childControl is CheckedListBox checkedList)
                {
                    for (int i = 0; i < checkedListBoxRol.Items.Count; i++)
                    {
                        checkedListBoxRol.SetItemChecked(i, false);
                    }
                }
                else if (childControl is ComboBox combo)
                {
                    combo.Text = " ";
                }
            }
        }

        private bool Activate(Control control)
        {
            if (modo == true)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (childControl is TextBox textBox)
                    {
                        textBox.Enabled = true;
                    }
                    else if (childControl is CheckedListBox checkedList)
                    {
                        allowChange = true;
                    }
                    else if (childControl is ComboBox combo)
                    {
                        combo.Enabled = true;
                    }
                }
                labelModo.Text = "Edicion Habilitada";
                textBoxID.Enabled = false;
                return true;
            }
            else if (modo == false)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (childControl is TextBox textBox)
                    {
                        textBox.Enabled = false;
                    }
                    else if (childControl is CheckedListBox checkedList)
                    {
                        allowChange = false;
                    }
                    else if (childControl is ComboBox combo)
                    {
                        combo.Enabled = false;
                    }
                }
                labelModo.Text = "Modo sólo lectura";
                textBoxID.Enabled = true;
                return false;
            }
            return false;
        }

        private void Create()
        {
            textBoxID.TextChanged -= textBoxID_TextChanged;
            textBoxID.Text = "";
            try
            {
                string nombre = textBoxNombre.Text;
                string sexo = comboBoxSexo.Text;
                string region = comboBoxRegion.Text;
                string alcance = comboBoxAlcance.Text;
                string recurso = textBoxRecurso.Text;
                StringBuilder selectedOptions = new StringBuilder();
                foreach (var item in checkedListBoxRol.CheckedItems)
                {
                    if (selectedOptions.Length > 0)
                    {
                        selectedOptions.Append("/");
                    }
                    selectedOptions.Append(item.ToString());
                }
                string rol = selectedOptions.ToString();
                string tipo = comboBoxDanio.Text;
                int aspectos = Convert.ToInt32(textBoxAspectos.Text);
                DialogResult confirmar = MessageBox.Show("Confirmar registro.","Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    league.CrearRegistro(nombre, sexo, region, recurso, alcance, rol, tipo, aspectos);
                    modo=false;
                    Activate(this);
                    MessageBox.Show("Creada");
                }
                else
                {
                    MessageBox.Show("Creacion Cancelada");
                }

            }
            catch (Exception ex)
            {
                Erase(this);
                MessageBox.Show("Datos Invalidos.");
            }
            textBoxID.TextChanged += textBoxID_TextChanged;
        }

        private void BuscarRegistro()
        {
            
            int idLeague = int.Parse(textBoxID.Text);
            DataTable personajeEncontrado = league.BuscarPorId(idLeague);
            if (personajeEncontrado.Rows.Count > 0)
            {
                allowChange = true;
                for (int i = 0; i < checkedListBoxRol.Items.Count; i++)
                {
                    checkedListBoxRol.SetItemChecked(i, false);
                }
                string nombre = personajeEncontrado.Rows[0]["Nombre"].ToString();
                string sexo = personajeEncontrado.Rows[0]["Sexo"].ToString();
                string region = personajeEncontrado.Rows[0]["Region"].ToString();
                string recurso = personajeEncontrado.Rows[0]["Recurso"].ToString();
                string alcance = personajeEncontrado.Rows[0]["Alcance"].ToString();
                string rol = personajeEncontrado.Rows[0]["Rol"].ToString();
                string danio = personajeEncontrado.Rows[0]["Tipo_de_Daño"].ToString();
                string aspectos = personajeEncontrado.Rows[0]["Numero_Aspectos"].ToString();

                textBoxNombre.Text = nombre;
                comboBoxSexo.Text = sexo;
                comboBoxRegion.Text = region;
                textBoxRecurso.Text = recurso;
                comboBoxAlcance.Text = alcance;
                string[] check = rol.Split('/');
                for (int i = 0; i < checkedListBoxRol.Items.Count; i++)
                {
                    string item = checkedListBoxRol.Items[i].ToString();

                    for (int j = 0; j < check.Length; j++)
                    {
                        if (check[j].ToString() == item)
                        {
                            checkedListBoxRol.SetItemChecked(i, true);
                        }
                    }
                }
                comboBoxDanio.Text = danio;
                textBoxAspectos.Text = aspectos;
            }
            else
            {
                MessageBox.Show($"El ID {textBoxID.Text} no existe");
                textBoxID.Text = "";
            }
            allowChange = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBoxRol.Items.AddRange(roles);
            comboBoxRegion.Items.AddRange(regions);
            comboBoxSexo.Items.AddRange(sexo);
            comboBoxAlcance.Items.AddRange(alcance);
            comboBoxDanio.Items.AddRange(danio);
        }

        private void buttonProbar_Click(object sender, EventArgs e)
        {
            player.Play();
            LoadTable();
            MessageBox.Show("Tabla Cargada");
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            player.Play();
            if (Activate(this)==true)
            {
                Create();
            }
            else
            {
                modo = true;
                Activate(this);
                MessageBox.Show("Edicion Habilitada");
            }
        }

        private void buttonRegistro_Click_1(object sender, EventArgs e)
        {
            player.Play();
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Tienes que ingresar un ID para buscar");
            }
            else
            {
                BuscarRegistro();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            player.Play();
            if (string.IsNullOrEmpty(textBoxID.Text) || string.IsNullOrEmpty(textBoxNombre.Text))
            {
                MessageBox.Show("Tienes que ingresar un ID y buscarlo para actualizar");
            }
            else
            {
                if (textBoxID.Enabled == false)
                {
                    MessageBox.Show("Termina la operacion que estabas haciendo");
                }
                else
                {
                    modo = true;
                    Activate(this);
                    textBoxID.Enabled = false;
                    buttonActualizar.Enabled = false;
                    buttonActualizar.Visible = false;
                    buttonActualizarConfirmar.Enabled = true;
                    buttonActualizarConfirmar.Visible = true;
                }

            }
        }

        private void buttonActualizarConfirmar_Click(object sender, EventArgs e)
        {
            player.Play();
            if (Activate(this) == true)
            {
                try
                {
                    string id = textBoxID.Text;
                    string nombre = textBoxNombre.Text;
                    string sexo = comboBoxSexo.Text;
                    string region = comboBoxRegion.Text;
                    string alcance = comboBoxAlcance.Text;
                    string recurso = textBoxRecurso.Text;
                    StringBuilder selectedOptions = new StringBuilder();
                    foreach (var item in checkedListBoxRol.CheckedItems)
                    {
                        if (selectedOptions.Length > 0)
                        {
                            selectedOptions.Append("/");
                        }
                        selectedOptions.Append(item.ToString());
                    }
                    string rol = selectedOptions.ToString();
                    string tipo = comboBoxDanio.Text;
                    int aspectos = Convert.ToInt32(textBoxAspectos.Text);
                    DialogResult confirmar = MessageBox.Show("Confirmar Actualizacion.", "Confirmar", MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes)
                    {
                        league.ActualizarRegistro(id, nombre, sexo, region, recurso, alcance, rol, tipo, aspectos);
                        MessageBox.Show("Actualizada");
                        LoadTable();
                        modo = false;
                        Activate(this);
                    }
                    else
                    {
                        MessageBox.Show("Actualizacion Cancelada");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datos invalidos");
                }
                buttonActualizarConfirmar.Enabled = false;
                buttonActualizarConfirmar.Visible = false;
                buttonActualizar.Enabled = true;
                buttonActualizar.Visible = true;
            }

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            player.Play();
            if (!String.IsNullOrEmpty(textBoxID.Text))
            {
                string id = textBoxID.Text;
                DialogResult confirmar = MessageBox.Show($"Quieres borrar el registro con el id de {id}?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    int respuesta = league.BorrarRegistro(id);
                    if (respuesta > 0)
                    {
                        MessageBox.Show("Borrado");
                    }
                    else
                    {
                        MessageBox.Show($"El ID {textBoxID.Text} no existe");
                        textBoxID.Text = "";
                    }
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Proceso Cancelado");
                }
            }
            else
            {
                MessageBox.Show("Tienes que ingresar un ID");
            }

        }

        //Para que los usuarios solo pueden ingresar los datos en las listas
        private void checkedListBoxRol_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!allowChange)
            {
                e.NewValue = e.CurrentValue;
            }
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            textBoxID.TextChanged -= textBoxID_TextChanged;
            try
            {
                if (!string.IsNullOrEmpty(textBoxID.Text))
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    if (id == 0)
                    {
                        textBoxID.Text = "";
                        MessageBox.Show("ID invalido");
                    }
                }
            }
            catch (Exception ex) 
            {
                textBoxID.Text = "";
                MessageBox.Show("Tienes que ingresar un numero.");
            }
            textBoxID.TextChanged += textBoxID_TextChanged;
        }

        private void comboBoxSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!char.IsControl(e.KeyChar) && !comboBox.Items.Contains(comboBox.Text + e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxAlcance_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!char.IsControl(e.KeyChar) && !comboBox.Items.Contains(comboBox.Text + e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!char.IsControl(e.KeyChar) && !comboBox.Items.Contains(comboBox.Text + e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxDanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!char.IsControl(e.KeyChar) && !comboBox.Items.Contains(comboBox.Text + e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
