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
        List<long> datos = new List<long>();
        Random rdn = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDatos.IntegralHeight = false;
            lstOrdenado.IntegralHeight = false;

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
            {
                datos.Add((long)rdn.Next(10, 50000));
            }

            swLista.Stop();


           
            DateTime inicioUI = DateTime.Now;

            Stopwatch swUI = new Stopwatch();
            swUI.Start();

            lstDatos.DataSource = null;
            lstDatos.DataSource = new List<long>(datos);

            swUI.Stop();
            lblTiempoFin.Text = "Fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDuracion.Text = "Tiempo mostrar: " + swUI.Elapsed.TotalSeconds + " s";


        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (cbOrdenamiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un algoritmo de ordenamiento.");
                return;
            }

            List<long> copia = new List<long>(datos);

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

            

            datos = copia;



            lstOrdenado.DataSource = null;
            lstOrdenado.DataSource = new List<long>(datos);
            sw.Stop();

            Application.DoEvents();


            lblTiempoFin.Text = "Fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDuracion.Text = $"Duración: {sw.Elapsed.TotalMilliseconds:F2} ms ({sw.Elapsed.TotalSeconds:F4} s)";
        }

        public void QuickSort(List<long> arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int p = Particionar(arr, inicio, fin);
                QuickSort(arr, inicio, p - 1);
                QuickSort(arr, p + 1, fin);
            }
        }

        private int Particionar(List<long> arr, int inicio, int fin)
        {
            long pivote = arr[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (arr[j] < pivote)
                {
                    i++;
                    long tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }

            long temp2 = arr[i + 1];
            arr[i + 1] = arr[fin];
            arr[fin] = temp2;

            return i + 1;
        }

        // InsertionSort con long
        public void InsertionSort(List<long> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                long key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        // BusquedaBinaria con long
        public int BusquedaBinaria(List<long> arr, long objetivo)
        {
            int inicio = 0;
            int fin = arr.Count - 1;

            while (inicio <= fin)
            {
                int mid = inicio + (fin - inicio) / 2;

                if (arr[mid] == objetivo)
                    return mid;

                if (arr[mid] < objetivo)
                    inicio = mid + 1;
                else
                    fin = mid - 1;
            }

            return -1;
        }

        // BusquedaLineal con long
        public int BusquedaLineal(List<long> arr, long objetivo)
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

            if (!int.TryParse(txtBuscar.Text.Trim(), out int buscar))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            if (datos.Count == 0)
            {
                MessageBox.Show("La lista está vacía. Genere datos primero.");
                return;
            }

            string algoritmo = cbBusqueda.SelectedItem.ToString();

            // ORDENAR PARA BINARIA
            if (algoritmo == "Binaria")
            {
                datos.Sort();

                // 🔥 REFRESCO COMPLETO Y REAL DEL UI
                lstDatos.DataSource = null;
                lstDatos.Items.Clear();
                lstOrdenado.DataSource = new List<long>(datos); // NUEVA LISTA

                lstOrdenado.DataSource = null;
                lstOrdenado.Items.Clear();
                lstOrdenado.DataSource = new List<long>(datos); // NUEVA LISTA

                Application.DoEvents();
            }

            lblTiempoIni.Text = "Inicio: " + DateTime.Now.ToString("HH:mm:ss");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int pos = -1;

            if (algoritmo == "Lineal")
                pos = BusquedaLineal(datos, buscar);
            else
                pos = BusquedaBinaria(datos, buscar);

            sw.Stop();

            lblTiempoFin.Text = "Fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblTiempoBuscar.Text = $"Tiempo: {sw.Elapsed.TotalMilliseconds:F2} ms";
            lblDuracion.Text = $"Duración: {sw.Elapsed.TotalSeconds:F4} s";

            if (pos >= 0)
                lblResultado.Text = $"Resultado: Encontrado en posición {pos + 1} (índice {pos})";
            else
                lblResultado.Text = "Resultado: No encontrado";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
