namespace taller.Clases;
using taller.Interfaces;

public abstract class Vehiculo : Imonoplazainterface{
    protected string marca;
    protected bool encendido;
    protected bool apagado;
    protected bool detenido;
    protected bool moviendo;


    public Vehiculo(string marca){
        paramarca = marca;
        encendido = false;
        apagado = true;
        detenido = true;
        moviendo = false; 
    }
    public void encender(){
        if (encendido == true) {
            Console.WriteLine("No se puede encender porque esta encendido");
        }
            else{
                Console.WriteLine("Se encendio el vehiculo");
            }
        
    }

    public void apagar(){
        if (apagado == true) {
            Console.WriteLine("No se puede apagar ya que está apagado");
        }
            else {
                Console.WriteLine("se apago el vehiculo");
            }
        
    }
     
    public void detener(){
        if (detener == true) {
            Console.WriteLine("No se puede detener ya que esta detenido");
        }
            else {
                Console.WriteLine("se detuvo el vehiculo");
            }
        
    }

    public void movimiento(){
        if (moviendo == true){
            Console.WriteLine ("no se puede mover ya que esta en Movimiento");
        }
            else {
                Console.WriteLine("Se inicio el movimiento del vehiculo");
            }
        
    }
}
