import java.text.*;

public class Main {
  public static void main(String[] args) {
        
    String num = "9410200.453";
    String numero = String.format("%.6f", Float.parseFloat(num));
    
    System.out.println("num: " + num);
    System.out.println("numero: " + numero);
    
    DecimalFormatSymbols simbolo=new DecimalFormatSymbols();
    simbolo.setDecimalSeparator(',');
    simbolo.setGroupingSeparator('.');
    String patron = "$#,###.00";
    DecimalFormat decF = new DecimalFormat(patron, simbolo);
    String salida = decF.format(Double.parseDouble(num));
    System.out.println(num + ", '" + patron + "', " + salida);    
    
  }
}
