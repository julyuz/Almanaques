import java.util.*;

public class Main { 
  public static void main(String[] args) { 
    ArrayList<String> cars = new ArrayList<String>();
    cars.add("Volvo");
    cars.add("BMW");
    cars.add("Ford");
    cars.add("Mazda");
    cars.add("Volkswagen");
    cars.add("Audi");
    cars.add("Renault");
    cars.add("Mercedes Benz");
    cars.add("Chevrolet");
    System.out.println(cars);
    
    
    Collections.sort(cars);
    System.out.println("\nOrdenado: " + cars);

    Collections.sort(cars, Collections.reverseOrder());
    System.out.println("\nOrdenado ascendentemente: " + cars);
    
  } 
}