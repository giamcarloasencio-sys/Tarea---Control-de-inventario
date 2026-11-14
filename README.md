Control de inventario de TecnoPunto

Datos de los autores

Nombre: [GIAMCARLO ASENCIO ROBLES 2025-3103], [RONIEL JIMENEZ SANTANA 2025-3663], [WILBER TEJEDA FERNANDEZ 2025-3392]
Asignatura: Programación Básica
Profesor: Gamalier Reyes del Carmen
Universidad: Universidad Central del Este (UCE)

[Descripción del programa]

Este es un programa de consola hecho en C# para la tienda TecnoPunto, que llevaba su inventario en papel y se equivocaba bastante (precios negativos, cantidades raras y productos sin nombre). Lo que hice fue crear una clase Producto que se encarga de revisar los datos por sí misma, así no se puede guardar información mala.

La clase tiene las propiedades Codigo, Nombre, Precio y Cantidad. Cada una valida el dato en su bloque set:

El nombre no puede estar vacío.
El precio tiene que ser mayor que 0.
La cantidad no puede ser negativa (pero 0 sí se permite, porque un producto puede estar agotado).

También tiene la propiedad de solo lectura ValorTotal, que calcula precio × cantidad, y el método MostrarInfo() para imprimir todo. En el Main se piden por teclado los datos de 3 productos, se crean los objetos y se muestran. Si el usuario escribe algo inválido, sale un mensaje y se vuelve a pedir ese producto, para que el programa no se cierre.

*[Datos de entrada]

Por cada producto (3 en total) el usuario escribe:

Código
Nombre
Precio
Cantidad
Datos que procesa
Valida que el nombre y el código no estén vacíos.
Valida que el precio sea mayor que 0.
Valida que la cantidad no sea negativa.
Comprueba que el precio y la cantidad sean números.
Calcula el valor total en existencia de cada producto (precio × cantidad).

*[Datos de salida]

Mensajes de error claros cuando algún dato es inválido.
La información de cada producto: código, nombre, precio, cantidad y valor total.

Capturas de la ejecución

