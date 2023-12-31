## 1-Hello_Triangle

Generazione di una finestra con colore di sfondo.

Poi vengono utilizzati gli shader per disegnare il primo triangolo.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/1.PNG" width="300">

Disegno di due triangoli.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/2.PNG" width="300">

Infine sempre due triangoli ma con colori diversi.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/3.PNG" width="300">

## 2-Shader

Utilizzo degli shader. Passo un valore direttamente al fragment e nel ciclo di render cambio il suo valore a run-time.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/4.PNG" width="300">

Interpolazione dei colori.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/5.PNG" width="300">

Modifica del vertex shader per capovolgere il trinagolo.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/6.PNG" width="300">

Utilizzo di un offset per spostare il triangolo sull'asse orrizzontale.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/7.PNG" width="300">

Infine il vertex shader restituisce in output il vettore posizione, utilizzato poi dal fragment per colorare.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/8.PNG" width="300">

## 3-Texture

Aggiunta della prima texture a un rettangolo.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/9.PNG" width="300">

Caricamento di una seconda texture mixandola alla prima.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/10.PNG" width="300">

Cambio la percentuale di mix tra le due texture a run-time o con le frecce della tastiera.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/11.PNG" width="300">

Infine applico diversi metodi di wrapping.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/12.PNG" width="300">

## 4-Tranformation

Ora si applicano delle trasformazioni. La prima è la traslazione.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/13.PNG" width="300">

Poi il rettangolo ruota attorno al centro dello schermo.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/14.PNG" width="300">

Infine vengono implementate diverse trasformazioni a due rettangoli.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/15.PNG" width="300">

## 5-Coordinate_System

Sposto le coordinate dei vertici attraverso le matrici model, view e projection.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/16.PNG" width="300">

Disegno un cubo implementando uno z-buffer in cui vengono salvate le informazioni di profondità.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/17.PNG" width="300">

Vari cubi con posizioni e rotazioni random. Infine alcuni ruotano su se stessi.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/18.PNG" width="300">

## 6-Camera

Nell'ultima parte del primo capitolo viene implementata la camera. Prima ruota nel tempo attorno alla scena, poi è possibile muoverla con WASD da tastiera e con il mouse. Inoltre con la rotella del mouse gestisco lo zoom. Infine viene gestita la camera come se ci si trovasse all'interno di un videogioco FPS e per ultimo è stata creata la propria funzione LookAt.

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/19.PNG" width="300">
