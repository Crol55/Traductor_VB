import java.util.Scanner;
public class Archivo2{
static Scanner sc = new Scanner(System.in);
public static void main(String[] Args){
SentenciaCiclos();
 hacerOperaciones();
 Matrices();
}
public static void SentenciaCiclos(){
 int opcion=0;
 while (opcion!=7){
System.out.println("Seleccione una opcion") ;
 System.out.println("1. For incremental en 1") ;
 System.out.println("2. For incremental en 3") ;
 System.out.println("3. For decremental") ;
 System.out.println("4. While con condicion") ;
 System.out.println("5. While con break") ;
 System.out.println("6. Do while") ;
 System.out.println("7. Salir") ;
 opcion=sc.nextInt();
 switch(opcion){
case 1:
System.out.println("For incremental") ;
 for (int number=0;number<10;number=number+1){
System.out.println(number+" ") ;
}
break;
case 2:
System.out.println("For incremental en 3") ;
 for (int number=0;number<20;number=number+3){
System.out.println(number+" ") ;
}
break;
case 3:
System.out.println("For decremental") ;
 for (int number=20;number>0;number=number-1){
System.out.println(number+" ") ;
}
break;
case 4:
System.out.println("While con condicion") ;
 System.out.println("Ingrese el limite final") ;
  int fin=sc.nextInt();
  int inicio=0;
 while (inicio<=fin){
System.out.println(inicio+" ") ;
 inicio=inicio+1;
}
break;
case 5:
System.out.println("while con break") ;
 while (true){
System.out.println("ingrese un numero") ;
  int num=sc.nextInt();
 if(num==10){
break;
}else {
System.out.println(num) ;
}

}
break;
case 6:
System.out.println("Do while") ;
 System.out.println("ingrese un numero") ;
  int num=sc.nextInt();
 do{
System.out.println(num+" ") ;
 num=num+1;
}while(num>10);
break;
case 7:
if(true){
break;
}
break;
default:System.out.println("Opcion Incorrecta") ;
}
}
}
public static int sumar(int op1,int op2){

return op1+op2;
}
public static int multiplicar(int op1,int op2){

return op1*op2;
}
public static String concatenar(int valor){

return "El resultado es "+valor;
}
public static void hacerOperaciones(){
 int op;
 op=0;
  int operando1,operando2;
 while (op!=3){
System.out.println("Seleccione una opcion") ;
 System.out.println("1. Sumar") ;
 System.out.println("2. Multiplicar") ;
 System.out.println("3. Salir") ;
 op=sc.nextInt();
 switch(op){
case 1:
System.out.println("ingrese el primer operando") ;
 operando1=sc.nextInt();
 System.out.println("ingrese el segundo operando") ;
 operando2=sc.nextInt();
  int resultado=sumar(operando1,operando2);
  String cadena=concatenar(resultado);
 System.out.println(cadena) ;
break;
case 2:
System.out.println("ingrese el primer operando") ;
 operando1=sc.nextInt();
 System.out.println("ingrese el segundo operando") ;
 operando2=sc.nextInt();
 resultado=multiplicar(operando1,operando2);
 cadena=concatenar(resultado);
 System.out.println(cadena) ;
break;
case 3:
if(true){
break;
}
break;
default:System.out.println("Opcion Incorrecta") ;
}
}
}
public static void Matrices(){
 int matriz [][]=new int[5][5];
 for (int i=0;i<5;i=i+1){
for (int j=0;j<5;j=j+1){
matriz[i][j]=i*2;
}
}
 System.out.println("Imprimir valores de las matrices") ;
 for (int i=0;i<5;i=i+1){
for (int j=0;j<5;j=j+1){
System.out.println(matriz[i][j]) ;
}
}
}

}