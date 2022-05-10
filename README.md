# ProjetoReceptorDeSinais
Este projeto visa simular uma API que recebe de sensores e exibe em tempo real um dashboard com os dados recebidos.

Para simular os dados enviados pelos receptores, devemos efetuar um post utilizando o Postman, por exemplo, e acompanhar a atualização em tempo real.

A  API com o método POST utilizada é a seguinte: http://localhost:57654/api/receptor/receiver.

Os dados Json abaixo podem ser utilizados como exemplo.

{
   "time_stamp": 1539112021301,
   "tag": "brasil.norte.sensor03",
   "valor" : "1000"
}

{
   "time_stamp": 1539112021302,
   "tag": "brasil.sudeste.sensor02",
   "valor" : "1200"
}

{
   "time_stamp": 1539112021301,
   "tag": "brasil.nordeste.sensor01",
   "valor" : "1500"
}
