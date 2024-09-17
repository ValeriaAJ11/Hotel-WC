// Es un caso en el que se pregunta el número de personas que desean hospedarse,
// según eso, se asigna una habitación y se cobra según los días a hospedarse.
// Asimismo, se realiza un descuento según el caso y el IVA del 16%.


// Se crea el diccionario para relacionar los precios con el tipo de habitación
Dictionary<string, int> precios = new Dictionary<string, int>();
precios.Add("individual", 2500);
precios.Add("doble", 4600);
precios.Add("familiar", 5200);

// Se crea una lista de las habitaciones que hay disponibles
List<string> habitaciones = new List<string>();
habitaciones.Add("individual");
habitaciones.Add("doble");
habitaciones.Add("familiar");

// Se declaran las variables que se van a utizar
string tipoHabitacion = "";
double total = 0;
double iva = 0;
double descuento = 0;

// Se crea el bucle
int huespedes = 0;

while (huespedes < 1000)

{
    // Muestra las habitaciones que hay y sus precios
    string mensaje = "Bienvenidos al HOTEL WC";
    Console.WriteLine(mensaje);
    Console.WriteLine();
    Console.WriteLine("Los precios por habitación varían según las personas");
    Console.WriteLine();

    foreach (KeyValuePair<string,int> precio in precios)
    {
        Console.WriteLine($"Habitación {precio.Key} por noche cuesta {precio.Value}");
    }

    Console.WriteLine();

    // Pregunta cuántos desean hospedarse y cuántos días
    Console.WriteLine("¿Cuántas personas desean hospedarse?");
    short numeroPersonas = short.Parse(Console.ReadLine());

    Console.WriteLine("¿Cuántos días desean hospedarse?");
    short diasHospedar = short.Parse(Console.ReadLine());

    // Declara la variable tipo de habitación según las personas para comparar en el switch
    if (numeroPersonas == 1){
        tipoHabitacion = habitaciones[0];
    } else{
        if (numeroPersonas == 2){
            tipoHabitacion = habitaciones[1];
        } else{
            tipoHabitacion = habitaciones[2];
        }
    }

    switch (tipoHabitacion)
    {
        case string n when (tipoHabitacion == habitaciones[0]):
        {
            total = precios[habitaciones[0]] * diasHospedar;
            iva = total * (1+0.16);
            descuento = iva * (1-0.05);

        } break;
        case string n when (tipoHabitacion == habitaciones[1]):
        {
            total = precios[habitaciones[1]] * diasHospedar;
            iva = total * (1+0.16);
            descuento = iva * (1-0.09);

        } break;

        default:
        total = precios[habitaciones[2]] * diasHospedar;
        iva = total * (1+0.16);
        descuento = iva * (1-0.15);
        break;
    }

    Console.WriteLine();
    Console.WriteLine($"El precio sin IVA(16%) por la habitación es de ${total:F2}");
    Console.WriteLine($"El precio con IVA(16%) por la habitación es de ${iva:F2}");
    Console.WriteLine($"El total a pagar es de {descuento:F2}");
    Console.WriteLine();

    huespedes++;

}
