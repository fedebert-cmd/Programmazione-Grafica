## Esercitazione 2 - Point_Shadows

L'obbiettivo di questa esercitazione è generare ombre dinamiche in tutte le direzioni e per fare questo verranno usate le point lights in quanto nel mondo che ci circonda una luce proveniente da un punto emette ombre in tutte le direzioni.  
Per fare ciò si andrà a generare una Depth Map dalla prospettiva della luce, si campionerà la stessa in base alla posizione corrente del frammento e infine si confronterà ogni frammento col valore di profondità memorizzato per vedere se è in ombra.  
Innanzitutto bisogna generare una Depth Cubemap ma è costoso in quanto bisognerebbe fare il render della scena 6 volte, una per ogni faccia.
Quindi utilizziamo un geometry shader e assegnamo ad ognuna delle 6 facce una texture 2D il che permetterà di fare il render di tutte le facce una singola volta.
Il render si compone di 2 passaggi: la generazione della Depth Cubemap e il successivo utilizzo di esse per aggiungere le ombre.  
Poi viene utilizzata una Light Space Transformation Matrix per ognuna delle 6 facce, in modo da trasformare la geometria della scena in relativi spazi luminosi per tutte le direzioni della luce.  
Per fare il render dei depth value della Depth Cubemap abbiamo bisogno di 3 shader. In particolare il geometry shader sarà responsabile di trasformare tutti i vertici del world space in 6 diversi light spaces
che poi andrà a passare al fragment shader che calcolerà i valori di profondità.  
Infine utilizziamo gli ultimi due shader per il render delle vere e proprie ombre.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/41.PNG" width="300">

Se si fa zoom nella scena ci si accorge che le ombre risulatano frastagliate quindi sarà necessario implementare la Percentage-Close Filtering (PCF) che permette di rendere
le ombre molto più smooth, andando a calcolare il valore dell'ombra come la media tra la sua ombra e quelle vicine.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/42.PNG" width="300">
