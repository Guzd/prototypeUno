using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototypeUno
{
    public partial class formPractica1 : Form
    {
        public formPractica1()
        {
            InitializeComponent();
        }

        /*--------------FRAME: Define los bytes para envio y recepción de datos----------------- */
        /*Se forma el paquete que sera enviado a arduino por comunicación serial para modificar
         * los parametros de los pines de entrada y salida. Así como la definición de los bytes necesarios
         * para la recepción de datos*/
        private byte[] paquete = new byte[6];                   //Se declara el paquete de bytes que sera enviado a arduino     
        private int sincronia1 = 65;                            //Byte 0  Estos tres bytes [0,1,2] sirven para identificar el 
        private int sincronia2 = 67;                            //Byte 1  inicio del paquete de datos. Corresponden a una letra
        private int sincronia3 = 69;                            //Byte 2  A, C, E en hexadecimal.
        private int nivel_salidas2 = 0;                         //Byte que contiene los datos utilizados para cambiar el estado (LOW-HIGH) de los pines utilizados
                                                                // int sumador = 0;                                //Byte que almacena el resultado de operacion. Indicará cuales pines de salida colocar en HIGH    
        private int envio_coordinador = 7;
        private int habilitar_envio = 0;

        private void formPractica1_Load(object sender, EventArgs e)
        {

        }

        private void BUSCA_PUERTO_Click(object sender, EventArgs e)
        {
            string[] puertosDisponibles = System.IO.Ports.SerialPort.GetPortNames(); //Obtiene una lista de los puertos  seriales disponibles
            PUERTO.Items.Clear();   //Limpia el combobox (Efecto de UX)
            foreach (string puertos in puertosDisponibles)
            {
                PUERTO.Items.Add(puertos);  //Utiliza un ciclo para añadir los puertos encontrados al combo box
            }
            if (PUERTO.Items.Count > 0)
            {   //Si existen puertos disponibles         
                MessageBox.Show("Seleccione un puerto y una velocidad de transmisión"); //despliega el mensaje     
                CONECTAR_DESCONECTAR.Enabled = true; // Habilita el boton que se encarga de establecer conexión con el puerto seleccionado. 
            }
            else
            {
                //Si no existen puertos
                MessageBox.Show("No se detectan puertos"); //Despliega el mensaje
                PUERTO.Items.Clear(); //Limpia el Combobox
                PUERTO.Text = "Puertos COM"; //Restablece el texto del combo box. 
                CONECTAR_DESCONECTAR.Enabled = false; // Deshabilita el boton que se encarga de establecer conexión con el puerto seleccionado. 
            }
        }

        /*------------CONECTAR:  establece  o no una conexión----------------- */
        /*Se conecta y desconecta. Abre y cierra el puerto, visualmente los botones
          cambian de apariencia */
        private void CONECTAR_DESCONECTAR_Click(object sender, EventArgs e)
        {
            try
            {
                // Para conectar. Evento que ocurre al presionar el boton para establecer conexion
                if (CONECTAR_DESCONECTAR.Text == "Conectar")
                { // Declaración de los parametros necerarios para la transmisión de datos
                    ConexionSerial.PortName = PUERTO.Text;  //Define el puerto. Adquiere el valor seleccionado en el combobox "PUERTO"
                    ConexionSerial.BaudRate = Int32.Parse(VELOCIDAD.Text); //Define la velocidad de transmisión. Adquiere el valor seleccionado en el combobox "VELOCIDAD"
                    ConexionSerial.Parity = System.IO.Ports.Parity.None; //Define la característica de  Pariedad = NONE
                    ConexionSerial.StopBits = System.IO.Ports.StopBits.One; //Define la característica de Bit de parada = ONE
                    ConexionSerial.DataBits = 8; //Obtiene o establece la longitud estándar de los bits de datos por byte.
                    ConexionSerial.Handshake = System.IO.Ports.Handshake.None; // Handshake = none
                    ConexionSerial.Open();  //Se abre el puerto
                    Temporizado.Enabled = true; //Se habilita el timer [cada cuánto se hará un envio de paquete] Programado desde el entorno gráfico a 500 ms.
                    btnOut1.Enabled = true;
                    btnOut2.Enabled = true;
                    btnOut3.Enabled = true;
                    btnOut4.Enabled = true;
                    btnOut5.Enabled = true;
                    btnOut6.Enabled = true;
                    btnOut7.Enabled = true;
                    btnOut8.Enabled = true;                                       
                    try
                    {
                        //Cambia la interfaz para desconectar
                        CONECTAR_DESCONECTAR.Text = "Desconectar"; //Cambia el texto impreso en el botón de "Conexión/desconexión"
                        CONECTAR_DESCONECTAR.BackColor = Color.Red; //Cambia el color del botón
                        BUSCA_PUERTO.Enabled = false;  //Inhabilita el boton de busqueda de puertos. 
                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString()); //En caso de no poder conectar [ej. Puerto ocupado]
                    }
                }
                //Entra al dar click y que el boton tenga como texto "Desconectar"
                else if (CONECTAR_DESCONECTAR.Text == "Desconectar")
                {
                    Temporizado.Enabled = false;    //Deshabilita el timer de transmisión de datos.
                    ConexionSerial.Close();         //Cierra el puerto
                    CONECTAR_DESCONECTAR.Text = "Conectar"; //Cambia el texto del botón 
                    CONECTAR_DESCONECTAR.BackColor = Color.Lime; //Cambia el color del botón 
                    BUSCA_PUERTO.Enabled = true; //Habilita de nuevo el botón de busqueda de puertos.
                    PUERTO.Text = "Puertos COM"; //Regresa el combobox de puertos a su estado inicial
                    VELOCIDAD.Text = "Vel. Transmisión"; //Regresa el combobox de Velocidad a su estado inicial
                    btnOut1.Enabled = false;
                    btnOut2.Enabled = false;
                    btnOut3.Enabled = false;
                    btnOut4.Enabled = false;
                    btnOut5.Enabled = false;
                    btnOut6.Enabled = false;
                    btnOut7.Enabled = false;
                    btnOut8.Enabled = false;

                    btnOut1.Text = "HIGH";
                    btnOut2.Text = "HIGH";
                    btnOut3.Text = "HIGH";
                    btnOut4.Text = "HIGH";
                    btnOut5.Text = "HIGH";
                    btnOut6.Text = "HIGH";
                    btnOut7.Text = "HIGH";
                    btnOut8.Text = "HIGH";
                    nivel_salidas2 = 0b00000000;

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString()); //En caso de no haber seleccionado las propiedades de transmisión (Puerto y velocidad)
            }
        }

        /*---------------------- CONTROL DE SALIDAS----------------------------------*/
        /*Esta sección permite el cambio de estado de los pines de salida declarados en arduino 
         en función del evento de un boton, al cambiar el estado y texto del botón se modifica el
         contenido del byte de datos que indica si el pin debe estar en HIGH o LOW. 
        Esta compuesta por una serie de botones[8] que definen el estado de los pines
         definidos como salida. Utiliza operaciones lógicas para comprobar la instrucción recibida; 
         And = coloca CEROS
         OR = Coloca UNOS
         Ejemplo:
            rb_Entradas = rb_Entradas | 0b00000001; <- Esta linea al hacer or con el byte el resultado
            unicamente será 1 para el primer bit cuando la Entrada ya tenga un 1 en el primer bit en caso contrario 
            colocará un cero en el bit 1 apagandolo
            | 0b10010001     & 0b10010001
              0b00000001       0b11111110
             ____________    ____________
              0b10010001       0b10010000 
                   a               b
                   
             a= enciende el primer bit deseado y respeta el estado de los demás bits
             b= mantiene encendidos los demás bits y apaga el bit indicado, en este caso el menos significativo*/
        //Boton de la Salida 1 bit [LSB 0b00000001]
        private void btnOut1_Click(object sender, EventArgs e)
        {
            if (btnOut1.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b00000001;
                btnOut1.Text = "LOW";



            }
            else if (btnOut1.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b11111110;
                btnOut1.Text = "HIGH";

            }
        }

        //Boton de la Salida 2 bit [0b00000010]
        private void btnOut2_Click(object sender, EventArgs e)
        {
            if (btnOut2.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b00000010;
                btnOut2.Text = "LOW";
            }
            else if (btnOut2.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b11111101;
                btnOut2.Text = "HIGH";
            }
        }

        //Boton de la Salida 3 bit [0b00000100]
        private void btnOut3_Click(object sender, EventArgs e)
        {
            if (btnOut3.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b00000100;
                btnOut3.Text = "LOW";

            }
            else if (btnOut3.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b11111011;
                btnOut3.Text = "HIGH";

            }
        }

        //Boton de la Salida 4 bit [0b00001000]
        private void btnOut4_Click(object sender, EventArgs e)
        {
            if (btnOut4.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b00001000;
                btnOut4.Text = "LOW";

            }
            else if (btnOut4.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b11110111;
                btnOut4.Text = "HIGH";

            }
        }

        //Boton de la Salida 5 bit [0b00010000]
        private void btnOut5_Click(object sender, EventArgs e)
        {
            if (btnOut5.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b00010000;
                btnOut5.Text = "LOW";

            }
            else if (btnOut5.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b11101111;
                btnOut5.Text = "HIGH";

            }
        }

        //Boton de la Salida 6 bit [0b00100000]
        private void btnOut6_Click(object sender, EventArgs e)
        {
            if (btnOut6.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b00100000;
                btnOut6.Text = "LOW";

            }
            else if (btnOut6.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b11011111;
                btnOut6.Text = "HIGH";

            }
        }

        //Boton de la Salida 7 bit [0b01000000]
        private void btnOut7_Click(object sender, EventArgs e)
        {
            if (btnOut7.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b01000000;
                btnOut7.Text = "LOW";

            }
            else if (btnOut7.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b10111111;
                btnOut7.Text = "HIGH";

            }
        }

        //Boton de la Salida 8 bit [MSB 0b10000010]
        private void btnOut8_Click(object sender, EventArgs e)
        {
            if (btnOut8.Text == "HIGH")
            {
                nivel_salidas2 = nivel_salidas2 | 0b10000000;
                btnOut8.Text = "LOW";

            }
            else if (btnOut8.Text == "LOW")
            {
                nivel_salidas2 = nivel_salidas2 & 0b01111111;
                btnOut8.Text = "HIGH";

            }
        }
        /*Fin de seccion--------------------------------------------------------*/

        /*--------------------------RECEPCION DE DATOS------------------------------*/
        /*Interrupcion o evento de recepcion que nos dice cuando recibe un paquete por parte
         de Arduino.  */
        int index = 0;
        byte[] datos = new byte[100];

        private void ConexionSerial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //Lee una cadena de BYTES
            ConexionSerial.Read(datos, 0, 5);

            while (datos[index] != 65)
            { //Este ciclo busca el bit se sincronia para evitar la lectura de bytes incompletos
                index = index + 1;  // utiliza un index para poder ubicarse a lo largo del byte
                datos[4 + index] = (byte)ConexionSerial.ReadByte();
            }
            if (datos[index] == 65 && datos[index + 1] == 67 && datos[index + 2] == 69)
            {     //Cuando el se encuentra con la lectura del byte correcto verifica uno a uno el estado de los bits 
                  //if (datos[index + 4] == 0b11111111)
                  //{
                  //    lbconfirmacion.BackColor = Color.Gray;
                  //    lbconfirmacion.Text = "Correcto";

                //}

                //if (datos[index + 4] == 0b00000000)
                //{
                //    lbconfirmacion.BackColor = Color.Red;
                //    lbconfirmacion.Text = "Incorrecto";
                //}

                if (datos[index + 3 ] == 0)
                {
                    btnNodo0.Text = "Nodo 0";
                    lbNodo0.Text = Convert.ToString(datos[index + 4]);
                }
                if (datos[index + 3] == 1)
                {
                    btnNodo1.Text = "Nodo 1";
                    lbNodo1.Text = Convert.ToString(datos[index + 4]);
                }

                
                lbconfirmacion.Text = Convert.ToString(datos[index + 4]);

            }
            index = 0;

        }
        /*Fin de sección-------------------------------------------------------------*/


        /*------------------ENVIO DE PAQUETES DE DATOS POR PUERTO SERIAL--------------*/
        /*Este evento está asociado al timer cuyo intervalo es de 500ms. Cada 500ms hará 
         la comprobación del paquete e implementará el método Serial.Write para enviar el
         paquete de bytes. Cada que se modifica la interfaz se actualiza el paquete de bytes*/

        private void Temporizado_Tick(object sender, EventArgs e)
        {
            //Un vez formado el paquete, este se envia a Arduino
            paquete[0] = (byte)sincronia1; // Estos bytes sirven para indicar el inicio de la trama
            paquete[1] = (byte)sincronia2; // Estos bytes sirven para indicar el inicio de la trama
            paquete[2] = (byte)sincronia3; // Estos bytes sirven para indicar el inicio de la trama
            paquete[3] = (byte)nivel_salidas2; // Byte que contiene la información que marca las instrucciones al arduino
            paquete[4] = (byte)envio_coordinador;
            paquete[5] = (byte)habilitar_envio;

            //Metodo para enviar un paquete de BYTES
            ConexionSerial.Write(paquete, 0, paquete.Length);
            habilitar_envio = 0;

        }
        /*Fin de seccion ---------------------------------------------------------------*/

        private void cbNodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbNodos.SelectedItem.ToString().Trim())
            {

                case "Broadcast":
                    envio_coordinador = 0;
                    break;

                case "Nodo 0":
                    envio_coordinador = 10;
                    break;

                case "Nodo 1":
                    envio_coordinador = 12;
                    break;

                case "Nodo 2":
                    envio_coordinador = 14;
                    break;

                case "Nodo 3":
                    envio_coordinador = 16;
                    break;

                case "Nodo 4":
                    envio_coordinador = 18;
                    break;

                case "Nodo 5":
                    envio_coordinador = 20;
                    break;

                default:

                    break;
            }
        }


        /*--------------------------CIERRE DEL FORM------------------------------*/

        private void formPractica1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConexionSerial.Close(); // Al cerrar el form se asegura de cerrar el puerto serial 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
