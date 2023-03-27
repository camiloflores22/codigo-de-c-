
class Estudiante {
  private double nota1;
  private double nota2;
  private double nota3;
  
  public Estudiante(double nota1, double nota2, double nota3) {

       this.nota1=nota1;
       this.nota2=nota2;
       this.nota3=nota3;

  }
         
 public double  calcularpromedio(){
    double promedio = (nota1+nota2+nota3) /3;
    return promedio;
 }
}
class Program {
  static void Main(string[] args) {
    Estudiante estudiante1 = new Estudiante(6.0, 5.4, 5.2);
    Estudiante estudiante2 = new Estudiante(4.0, 6.0, 5.6);
    Estudiante estudiante3 = new Estudiante(3.0, 5.0, 4.5);

    Console.WriteLine("Promedio del estudiante1 es:" + estudiante1.calcularpromedio());
    Console.WriteLine("Promedio del estudiante2 es:" + estudiante2.calcularpromedio());
    Console.WriteLine("Promedio del estudiante3 es:" + estudiante3.calcularpromedio());
  }
}


