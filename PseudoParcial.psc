Algoritmo PseudoParcial
	Definir Generatriz, Altura, Radio, Area, Volumen Como Real;
	
	Escribir "Ingrese la generatriz del cono: ";
    Leer Generatriz;
    Escribir "Ingrese la altura del cono: ";
    Leer Altura;
    Escribir "Ingrese el radio de giro del cono: ";
    Leer Radio;
	
	Area = 3.1416 * Radio * (Radio + Generatriz);
	Volumen = 1/3 * 3.1416 * Radio^2 * Altura;
	
	Escribir "El área del cono es:", Area;
    Escribir "El volumen del cono es:", Volumen;
	
FinAlgoritmo