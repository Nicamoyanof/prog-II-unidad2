using unidad_2_prog.Dominio;

namespace unidad_2_prog
{
    public partial class Form1 : Form
    {

        Pila pila = new Pila();
        Cola cola = new Cola();
        string[] lString = new string[6] { "prueba", "valor", "lleno", "casi", "prueba 2", null };
        List<object> lList = new List<object>();

        public Form1()
        {
            InitializeComponent();
            CargarLista();
            CargarListaCola();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEstaVacia.Text = pila.EstaVacia(lString).ToString();
        }

        public void CargarLista()
        {
            lstObjetos.Items.Clear();

            for (int i = 0; i < lString.Length; i++)
            {
                if (lString[i] != null)
                {
                    lstObjetos.Items.Add(lString[i]);
                }
                else
                {
                    lstObjetos.Items.Add("este seria nulo");
                }
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            txtExtraer.Text = pila.Extraer(lString).ToString();
            CargarLista();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            txtPrimero.Text = pila.Primero(lString).ToString();
            CargarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pila.Aniadir(lString, txtAgregar.Text))
            {
                MessageBox.Show("Agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarLista();
            }
            else
            {
                MessageBox.Show("No se pudo agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //COLAS


        public void CargarListaCola()
        {

            lstObjetosCola.Items.Clear();

            for (int i = 0; i < lList.Count; i++)
            {
                if (lList[i] != null)
                {
                    lstObjetosCola.Items.Add(lList[i]);
                }
                else
                {
                    lstObjetosCola.Items.Add("este seria nulo");
                }
            }
        }

        private void btnEstaVaciaCola_Click(object sender, EventArgs e)
        {
            txtEstaVaciaCola.Text = cola.EstaVacia(lList).ToString();
        }

        private void btnExtraerCola_Click(object sender, EventArgs e)
        {
            txtExtraerCola.Text = cola.Extraer(lList).ToString();
            CargarListaCola();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cola.Aniadir(lList, txtAgregarCola.Text))
            {
                MessageBox.Show("Agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarListaCola();
            }
            else
            {
                MessageBox.Show("No se pudo agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}