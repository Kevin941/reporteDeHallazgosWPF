using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace reporteDeHallazgos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
		private bool activado = false; 

        private void cambiaDeEstado(object sender, System.Windows.RoutedEventArgs e)
        {			
			if(activado==false) {
				
			VisualStateManager.GoToElementState(this.LayoutRoot, "botonMovido", true);
			}			
			else
			{
				VisualStateManager.GoToElementState(this.LayoutRoot, "botonOriginal", true);
			}
			
			activado = !activado; 
        	//VisualStateManager.GoToStateAction(this, "botonMovido", true);
        }

        private void selectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        	
        }

        private void captura(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void capturaDatosGeneralesLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
			if(this.tabItemDatosGenerales.IsSelected)
			{
        		VisualStateManager.GoToElementState(this.LayoutRoot, "estadoCapturaDeDatosCargado", true);
			}
        }

        private void capturaDeCantidadesCargado(object sender, System.Windows.RoutedEventArgs e)
        {
			if(this.tabItemCantidades.IsSelected)
			{
        		VisualStateManager.GoToElementState(this.LayoutRoot, "estadoCapturaDeCantidadesCargado", true);
			}
        }

        private void capturaDatosDePersonalLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	if(this.tabItemDatosDePersonal.IsSelected)
			{
        		VisualStateManager.GoToElementState(this.LayoutRoot, "estadoDatosDePersonalCargado", true);
			}
			
        }

        private void capturaDatosDeProductoCargado(object sender, System.Windows.RoutedEventArgs e)
        {
        	if(this.tabItemDatosDeProducto.IsSelected)
			{
        		VisualStateManager.GoToElementState(this.LayoutRoot, "estadoDatosDeProductoCargado", true);
			}
			
        }

        private void datosDetallesCargado(object sender, System.Windows.RoutedEventArgs e)
        {
        	if(this.tabItemDetalles.IsSelected)
			{
        		VisualStateManager.GoToElementState(this.LayoutRoot, "estadoDetallesCargado", true);
			}
        }

        private void botonContinuar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			if(this.tabControlPrincipal.SelectedIndex <this.tabControlPrincipal.Items.Count-1)
			{
				TabItem ti = this.tabControlPrincipal.SelectedItem as TabItem;  
				ti.IsEnabled = false; 
        		this.tabControlPrincipal.SelectedIndex++; 
				ti = this.tabControlPrincipal.SelectedItem as TabItem;  
				ti.IsEnabled = true; 
			}
        }

        private void botonRegresar_click(object sender, System.Windows.RoutedEventArgs e)
        {
        	if(this.tabControlPrincipal.SelectedIndex >0)
			{
				TabItem ti = this.tabControlPrincipal.SelectedItem as TabItem;  
				ti.IsEnabled = false; 
        		this.tabControlPrincipal.SelectedIndex--; 
				ti = this.tabControlPrincipal.SelectedItem as TabItem;  
				ti.IsEnabled = true; 
			}
        }

        private void ventanaPrincipalCargada(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("La ventana principal fue cargada"); 
        }      
    }
}
