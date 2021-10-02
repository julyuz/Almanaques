import java.time.LocalDateTime;  // Import the LocalDateTime class
import java.time.format.DateTimeFormatter;  // Import the DateTimeFormatter class

import java.text.SimpleDateFormat;
import java.text.ParseException;
import java.util.Date;
import java.util.Locale;

public class Main {

  public static void main(String[] args) {  
    // LOCALDATETIME OBJECT 
    LocalDateTime myDateObj = LocalDateTime.now();  
    System.out.println("Before formatting: " + myDateObj);  
    DateTimeFormatter myFormatObj = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss");  
    
    String formattedDate = myDateObj.format(myFormatObj);  
    System.out.println("After formatting: " + formattedDate);  
    
    DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd/MM/yyyy");
    formattedDate = myDateObj.format(dtf);
    System.out.println("'dd/MM/yyyy': " + formattedDate);
        
    try {
        // Formato en que viene la fecha
        SimpleDateFormat parseador = new SimpleDateFormat("yyyy-MM-dd hh:mm");
        // Formato deseado
        SimpleDateFormat formateador = new SimpleDateFormat("dd/MMM/yyyy hh:mm");

        SimpleDateFormat formatLocale = new SimpleDateFormat("EEEE dd 'de' MMMM 'del' yyyy hh:mm aa", new Locale("es", "ES"));

        Date date = parseador.parse("2021-02-10 18:10:50");
        System.out.println(formateador.format(date));
    } catch (ParseException exc) {
        exc.printStackTrace();
    }
  }  
   
}  
  