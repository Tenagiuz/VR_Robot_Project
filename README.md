REQUISITI DEL PROGETTO:
 
 - Simulazione robotica dove l'umano (human in the loop paradigm) gestisce delle risorse (torri) per respingere dei robot che cercano di     invadere la base principale (tower defense like);
 - I robot sono tutti di un determinato colore (combinazione RGB);
 - Le torri sono tutte di un determinato colore;
 - I robot sono dotati di videocamera (riconoscimento colore di torri e altri robot);
 - Il campo della simulazione è circolare;
 - I robot provengono dal perimetro del campo spawnando in punti random di esso;
 - L'arrivo dei robot è organizzato in 3 ondate di crescente difficoltà;
 - L'obiettivo dei robot è arrivare al centro del campo, "attaccando" ogni torre incontrata sul cammino;
 - Le torri vengono posizionate dall'umano sulla base di crediti guadagnati dalla distruzione dei robot;
 - La distruzione di un robot vale N crediti mentre la costruzione di una torre ne richiede M (valori da determinare sperimentalmente);
 - Le torri sono dotate di videocamera rotante a 360° che si fissa su un robot quando lo riconosce;
 - L'interazione tra torre e robot verrà gestita in questo modo: il robot si ferma a breve distanza dalla torre e comincia a simulare uno     sparo (modellato come lancio di un oggetto sferico);
 - La torre simula anch'essa uno sparo;
 - Torri, robot e base principale hanno tutti una quantità di "salute" al termine della quale vengono distrutti;
 - La simulazione termina con esito negativo se la base principale viene distrutta;
 - La simulazione termina con esito positivo se la base principale, al termine delle ondate, non è stata distrutta.
 
TECNOLOGIE E PATTERN UTILIZZATI:
 
 - Videocamera robot/torre: implementata tramite il seguente procedimento: il singolo frame estratto dalla videocamera virtuale di unity     viene inviato a un nodo ROS esterno (python) il quale tramite la libreria OpenCV restituisce dei dati contenenti l'esito dell'analisi     del frame. In particolare verrà utilizzata una mask per individuare oggetti di un determinato colore; 
 - Meccanismo di selezione delle torri implementato tramite gaze del visore in combinazione con il pad bluetooth (look to position);
 - Paradigma sense-think-act per robot e torri;
 - Paradigma human-in-the-loop;
 - Subroutine del think in Prolog.
