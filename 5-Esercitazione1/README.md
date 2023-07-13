## Esercitazione 1

In questa esercitazione si vuole operare un'integrazione di tutto quello visto fin'ora.  
Come prima cosa viene istanziato un modello statico in particolare sempre il backpack.obj visto nel capitolo del Model Loading.  
Successivamente viene aggiunto il lighting che si compone di: 1 luce direzionale, 4 point light di cui una ruota attorno al modello e una spotlight posta sulla camera.
Alle luci sono stati associati i colori presi dall'ultimo esercizio del secondo capitolo.
L'illuminazione passa quindi attraverso la definizione di tutte le strutture dati necessarie che poi dal programma vengono passati allo shader dedicato. Infine il lighting viene calcolato all'interno del tangent space.  
Come ultima cosa vengono implementate le funzioni riguardo l'input utente, in particolare il movimento della camera con i tasti WASD e la direzione di essa decisa dal movimento del mouse con tanto di zoom applicabile tramite lo scroll della rotellina. 

<img src="https://github.com/fedebert-cmd/Programmazione-Grafica/blob/main/Images/40.PNG" width="300">
