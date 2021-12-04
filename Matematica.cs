namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X {get; set;}
        public int Y {get; set;}

        public Matematica(int x, inty)
        {
            x = x;
            y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }
        public void Somar()
        {
            Calculadora.Somar(x,y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Metodo executado");
        }
    }
}