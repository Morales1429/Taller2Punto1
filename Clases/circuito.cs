namespace taller.Clases;
using taller.Interfaces;

public class circuito{
    protected int vueltas;
    protected Imonoplazainterface? monoplaza;
    public circuito(int limitevueltas){
    vueltas=limitevueltas;
    monoplaza = null;
    }

    public void agregarMonoplaza(Imonoplazainterface monoplazaExterno)
    {
        if(monoplaza == null) {
            monoplaza = monoplazaExterno;
        }
        //Write no se
    }
    public void EliminarMonoplaza(Imonoplazainterface eliminarMono)
    {
        if(monoplaza != null) {
            Console.WriteLine("Ya hay un monoplaza dentro");
        }
    }
    public int lanzarprueba ()
    {
        Random random = new Random();
        monoplaza.encender();
        monoplaza.moviendo();
        int mejorvuelta = 99999999;
        for (int i = 0; i < vuelta.Count; i++){
            int vuelta = random.Next(100000, 9999999);
            Console.WriteLine("La vuelta fue"+ vuelta);
            if (vuelta > mejorvuelta){
                mejorvuelta = vuelta;
            }
        }

        return mejorvuelta;
    }
}
