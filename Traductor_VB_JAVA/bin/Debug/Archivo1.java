import java.util.Scanner;
public class Archivo1{
static Scanner sc = new Scanner(System.in);
public static void main(String[] Args){
SentenciaSwtich(1);
 SentenciaIf(63);
}
public static void SentenciaSwtich (int nota){
switch(nota){
case 1:
System.out.println("Su numero es 1") ;
break;
case 2:
System.out.println("Su numero ingresada es 2") ;
break;
case 3:
System.out.println("Su numero ingresada es 3") ;
break;
default:System.out.println("ES OTRA NUMERO") ;
}
}
public static void SentenciaIf (int nota){
System.out.println("Sunota es "+nota) ;
 if(nota<=100&&nota>=0){
if(nota<=100&&nota>=80){
System.out.println("Gano con buena nota") ;
System.out.println("Gano con buena nota") ;
}
}else {
System.out.println("La nota no es valida") ;
}

}

}