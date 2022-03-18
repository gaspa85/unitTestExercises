# unitTestExercises
exercises for testing

fare un esempio ex novo ripartire da li e poi rivedere problematiche 
scritture di codice.

fare a livello di codice api che gestisca inserimento e lettura (no modifica no delete)
questo prodotto deve avere uno storico di prezzi e scontistiche ( le scontistiche cambiano più frequestemente dei prezzi)

le scontisctiche sono fisse multipli di 5, dal 5 al 50%
dalle specifiche appena descritto

- prima scrivere specifiche unit test
- fare varie classi
- integrazion test 	mongo entity framwork, dapper
- dopo integration test / moking test
- end to end test


qualora non si finisca oggi portarlo avanti nel tempo da qui e conclusione corsi
in caso si tagga sul repositori e si fa code review su codice
più che tecniche più scenari di comprensione






##Specifica dettagliata

Vogliamo gestire l'inserimento e la lettura di un prodotto a una certa data.

Il prodotto ha come informazioni basilari quelle elementari come:

Nome
Data di scadenza (opzionale)
Codice EAN
Le caratteristiche del prodotto principali sono:

Prezzo, sempre presente e con un range di date. Il range ha sempre una data di inizio e di fine ed è sempre presente.

 

Sconto, opzionale.

Lo sconto ha un range di date sempre presente e a scaglioni di 5 punti.

Da 5% a 50%.

 

L'applicazione avrà un API per l'inserimento del prodotto e due API per la lettura del prodotto. La prima estrae l'articolo ad una specifica data. Il secondo riporta lo storico di tutti i cambiamenti
 

Implementare il codice in modalità TDD (partendo dai test).

Integration test (Entity Framework, Dapper, Moq, Mongo VALUTATE VOI).
