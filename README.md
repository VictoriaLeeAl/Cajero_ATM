# Cajero_ATM
Simulación de Cajero ATM, se realizarán operaciones y consultas en base a información predeterminada y proporcionada por el usuario.

### Planteamiento del problema: 
Trabajas para una empresa de desarrollo de software, y te piden dar una solución que se encargue de administrar cajeros automáticos. 

Los casos de uso son los siguientes: 

+ **Retiro de dinero:** el cliente podrá retirar su dinero siempre y cuando cuente con los fondos suficientes, el número de tarjeta y pin coincidan, y su tarjeta no esté vencida. 
+ **Transferencia de fondos:** transferir dinero entre diferentes cuentas que se encuentren registradas como válidas. Se podrá realizar la transferencia de fondos, siempre y cuando la cantidad solicitada se tenga en la cuenta. 
+ **Depósito de fondos:** para depositar dinero a una cuenta se requiere el número de tarjeta a depositar y el monto. Se aceptan billetes únicamente, se debe especificar el monto a depositar, solicitar introducir billetes y realizar la validación, en caso de incumplir, se debe permitir modificar el monto a depositar. 
+ **Consulta de saldos:** el usuario podrá consultar en pantalla su saldo, solo si su número de tarjeta coincide con su pin. En caso de que la tarjeta esté vencida, se debe mostrar en pantalla el siguiente texto: “Su plástico ha vencido, pase a ventanilla para obtener uno nuevo.”. 

El banco nos ha proporcionado la siguiente información que representa los datos que ellos manejan: 
