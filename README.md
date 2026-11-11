<h1 align="center">🔎 InvestiCore</h1>

<p align="center">
  <strong>Sistema de gestión para una agencia de investigación privada</strong>
</p>

---

##  Descripción del proyecto

InvestiCore es una aplicación de consola desarrollada en **C#** para gestionar los servicios de una agencia de investigación privada.

El programa permite registrar expedientes de clientes, contratar servicios de investigación, añadir servicios adicionales, calcular importes y gestionar los pagos. También ofrece estadísticas sobre la actividad económica de la agencia.

---

##  Funcionalidades principales

La aplicación cuenta con un menú principal que ofrece tres opciones:

1. **Registrar nuevo expediente:** permite introducir los datos del cliente y del expediente, seleccionar un servicio principal y contratar servicios adicionales.
2. **Consultar estadísticas:** muestra información sobre los expedientes completados y los ingresos de la agencia.
3. **Salir:** finaliza el programa mostrando un resumen de la actividad.

---

##  Servicios disponibles

### Servicios principales

| Servicio | Precio |
|---|---:|
| Investigación documental | 80 € |
| Análisis de evidencias | 120 € |
| Investigación empresarial | 180 € |

### Servicios adicionales

| Servicio adicional | Precio |
|---|---:|
| Informe detallado | 25 € |
| Clasificación cronológica de evidencias | 35 € |
| Revisión documental adicional | 20 € |

Cada servicio adicional puede contratarse como máximo una vez por expediente.

---

##  Sistema de precios

InvestiCore aplica las siguientes condiciones económicas:

- **Modalidad normal:** no añade ningún suplemento.
- **Modalidad urgente:** incrementa el importe un 20 %.
- **Descuento:** se aplica un 10 % cuando el subtotal supera los 200 €.

El suplemento por urgencia se calcula después de aplicar el descuento.

Una vez calculado el importe final, el programa solicita el dinero entregado por el cliente y calcula el cambio correspondiente.

---

##  Estadísticas de la agencia

El programa permite consultar los siguientes datos:

- Número de expedientes completados y cobrados.
- Recaudación total de la agencia.
- Importe medio por expediente.
- Importe del expediente más caro.
- Nombre del cliente asociado al expediente de mayor importe.

---

##  Tecnologías utilizadas

- **Lenguaje de programación:** C#.
- **Entorno de ejecución:** aplicación de consola.
- **Plataforma:** .NET.

---

## ▶ Ejecución del programa

Para ejecutar el proyecto:

1. Abrir el proyecto en Visual Studio o en otro entorno compatible con .NET.
2. Compilar la aplicación.
3. Ejecutar el programa.
4. Seguir las instrucciones que aparecen en la consola.

---

##  Objetivo del proyecto

El objetivo de InvestiCore es poner en práctica los conocimientos básicos de programación en C#, utilizando:

- Variables y tipos de datos.
- Estructuras condicionales.
- Bucles.
- Operaciones matemáticas.
- Entrada y salida de datos por consola.

---

<p align="center">
  <strong>InvestiCore</strong><br>
  Gestión, investigación y precisión.
