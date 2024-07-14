# web-scrapper
Este es un proyecto de un web scrapper para hacer scrapping de una conocida web de venta de productos informáticos, debido a sus malas prácticas relacionadas con manipulación de precios antes/durante campañas de ofertas, las cuales ocultan y cambian los precios de los productos, haciéndolos parecer mejores ofertas de lo que son.  

Este es mi web scrapper personal con el cual puedo hacer un seguimiento de los productos que me interesan y ver sus precios reales y su evolución en el tiempo.

## Planificacion

### Características deseables
Azure Serverless Functions - hosting y trigger automatico en el tiempo  
  hacer un trigger que salte automaticamente una vez al dia en horas y minutos random    

Modelo de datos  
  Producto - quiero poder guardar tracking de multiples productos pudiendo añadir o quitar productos  
    string URL  
    string Nombre  
    string categoria  
    string Caracteristicas  
    long precio diario  
    long supuesto precio real  
    long precio historico maximo  
    long precio historico minimo  
    bool thirdparty?  

Base de datos - guardar en algun sitio todos estos datos  
  exportable en excel para poder sacar graficas y analisis de datos
