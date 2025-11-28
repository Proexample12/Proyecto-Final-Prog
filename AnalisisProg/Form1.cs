using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisProg
{
    public partial class Form1 : Form
    {
        List<int> datos = new List<int>();
        Random rdn = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            datos.Clear();

            if (!long.TryParse(tbCantidad.Text, out long tamaño) || tamaño < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            // Guardamos el tiempo de inicio antes de la operación
            DateTime inicio = DateTime.Now;
            lblTiempoIni.Text = "Inicio: " + inicio.ToString("HH:mm:ss");

            Stopwatch swLista = new Stopwatch();
            swLista.Start();

            for (long i = 0; i < tamaño; i++)
                datos.Add(rdn.Next(100, 500));

            swLista.Stop();


           
            DateTime inicioUI = DateTime.Now;

            Stopwatch swUI = new Stopwatch();
            swUI.Start();

            lstDatos.DataSource = null;
            lstDatos.DataSource = datos;

            // Forzar a que el UI procese el dibujado
            this.BeginInvoke(new Action(() =>
            {
                swUI.Stop();
                lblTiempoFin.Text = "Fin: " + DateTime.Now.ToString("HH:mm:ss");
                lblDuracion.Text = "Tiempo mostrar: " + swUI.Elapsed.TotalSeconds + " s";
            }
            ));
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cbOrdenamiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un algoritmo de ordenamiento.");
                return;
            }

            List<int> copia = new List<int>(datos);

            lblTiempoIni.Text = "Inicio: " + DateTime.Now.ToString("HH:mm:ss");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            string algoritmo = cbOrdenamiento.SelectedItem.ToString();

            if (algoritmo == "Insertion Sort")
            {
                InsertionSort(copia);
            }
            else if (algoritmo == "Quick Sort")
            {
                QuickSort(copia, 0, copia.Count - 1);
            }

            sw.Stop();

            datos = copia;
            lstOrdenado.DataSource = null;
            lstOrdenado.DataSource = datos;

            lblTiempoFin.Text = "Fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDuracion.Text = $"Duración: {sw.Elapsed.TotalMilliseconds:F2} ms ({sw.Elapsed.TotalSeconds:F4} s)";
        }






        public void QuickSort(List<int> arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int p = Particionar(arr, inicio, fin);
                QuickSort(arr, inicio, p - 1);
                QuickSort(arr, p + 1, fin);
            }
        }

        private int Particionar(List<int> arr, int inicio, int fin)
        {
            int pivote = arr[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (arr[j] < pivote)
                {
                    i++;
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[fin];
            arr[fin] = temp2;

            return i + 1;
        }


        public void InsertionSort(List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public int BusquedaBinaria(List<int> arr, int objetivo)
        {
            int inicio = 0;
            int fin = arr.Count - 1;

            while (inicio <= fin)
            {
                int mid = (inicio + fin) / 2;

                if (arr[mid] == objetivo)
                    return mid;
                else if (objetivo < arr[mid])
                    fin = mid - 1;
                else
                    inicio = mid + 1;
            }
            return -1;
        }
        /// <summary>
        /// xd
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="objetivo"></param>
        /// <returns></returns>


        public int BusquedaLineal(List<int> arr, int objetivo)
        {
            for (int i = 0; i < arr.Count; i++)
                if (arr[i] == objetivo)
                    return i;
            return -1;
        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un algoritmo de búsqueda.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese un número a buscar.");
                return;
            }

            if (!int.TryParse(txtBuscar.Text, out int buscar))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            string algoritmo = cbBusqueda.SelectedItem.ToString();

            if (algoritmo == "Binaria")
            {
                datos.Sort();


                if (datos == null || datos.Count == 0)
                {
                    MessageBox.Show("La lista está vacía. Genere y ordene datos primero.");
                    return;
                }
                
            }

            DateTime inicio = DateTime.Now;
            lblTiempoIni.Text = "Inicio: " + inicio.ToString("HH:mm:ss");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int pos = -1;
            if (algoritmo == "Lineal")
                pos = BusquedaLineal(datos, buscar);
            else if (algoritmo == "Binaria")
                pos = BusquedaBinaria(datos, buscar);

            sw.Stop();
            DateTime fin = DateTime.Now;
            lblTiempoFin.Text = "Fin: " + fin.ToString("HH:mm:ss");

            if (pos >= 0)
                lblResultado.Text = $"Resultado: Encontrado en posición {pos + 1} (índice {pos})";
            else
                lblResultado.Text = "Resultado: No encontrado";

            lblTiempoBuscar.Text = "Tiempo: " + sw.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
            lblDuracion.Text = "Duración: " + sw.Elapsed.TotalSeconds.ToString("F4") + " s";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
