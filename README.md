Control de inventario de TecnoPunto

Datos de los autores

Nombres: 

[GIAMCARLO ASENCIO ROBLES 2025-3103] 

[RONIEL JIMENEZ SANTANA 2025-3663] 

[WILBER TEJEDA FERNANDEZ 2025-3392]


Asignatura: Programación Básica

Profesor: Gamalier Reyes del Carmen

Universidad: Universidad Central del Este (UCE)

Descripción del programa

Este es un programa de consola hecho en C# para la tienda TecnoPunto, que llevaba su inventario en papel y se equivocaba bastante (precios negativos, cantidades raras y productos sin nombre). Lo que hice fue crear una clase Producto que se encarga de revisar los datos por sí misma, así no se puede guardar información mala.

La clase tiene las propiedades Codigo, Nombre, Precio y Cantidad. Cada una valida el dato en su bloque set:

El nombre no puede estar vacío.
El precio tiene que ser mayor que 0.
La cantidad no puede ser negativa (pero 0 sí se permite, porque un producto puede estar agotado).

También tiene la propiedad de solo lectura ValorTotal, que calcula precio × cantidad, y el método MostrarInfo() para imprimir todo. En el Main se piden por teclado los datos de 3 productos, se crean los objetos y se muestran. Si el usuario escribe algo inválido, sale un mensaje y se vuelve a pedir ese producto, para que el programa no se cierre.

Datos de entrada

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

Datos de salida

Mensajes de error claros cuando algún dato es inválido.
La información de cada producto: código, nombre, precio, cantidad y valor total.

Capturas de la ejecución

<img width="395" height="805" alt="b3e6fc51-1c77-48c4-ae00-d2190cfdddbc" src="https://github.com/user-attachments/assets/42545989-020a-4c79-a157-aff445483b41" />

<img width="446" height="829" alt="422e9b78-230a-49cf-ad02-b5b37c2748ac" src="https://github.com/user-attachments/assets/09c1e138-99af-4ec7-b3e2-37a591dd1fd7" />

<img width="929" height="724" alt="dbd05381-7045-42e0-a0a3-39dfd2ba47a7" src="https://github.com/user-attachments/assets/c339ffdf-ed62-4020-bf1e-a6f37a7fb9fe" />
