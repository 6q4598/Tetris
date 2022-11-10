# Tetris
Aquest és un programa tutorial per tal d'aprendre la programació en C#.

El Tetris és un videojoc de tipus trencaclosques. Fou inventat per l'enginyer informàtic rus Aleksei Pàjitnov l'any 1984, mentre treballava a l'Acadèmia de Ciències de Moscou.

Pàjitnov es va inspirar en un joc molt conegut i tradicional a Rússia anomenat Pentaminó. El joc però, és d'origen àrab. Va programar una nova versió d'aquest joc en un ordinador Electronica 60. Explica la llegenda que Pàjitnov el creà en una sola tarda; és possible que la llegenda no falti a la veritat perquè Tetris es pot programar gairebé en qualsevol tipus de llenguatge de programació en una sola tarda. S'ha de tenir en compte que el realment complex del Tetris va ser dissenyar la seva mecànica de joc i no la programació en si mateixa. Avui en dia és molt senzill copiar les seves regles per jugar-hi.

Unes peces bidimensionals de quatre blocs en diferents disposicions cauen des de la part superior de la pantalla. El jugador no pot impedir aquesta caiguda però pot decidir el lloc on caurà la peça i la seva rotació en 0°, 90°, 180° o 270°. Quan una línia horitzontal es completa, aquesta línia desapareix i totes les peces que estan a sobre descendeixen una posició, alliberant així espai de joc i per tant facilita la tasca de situar noves peces. La caiguda dels blocs s'accelera de forma constant. El joc s'acaba quan s'amunteguen fins a sortir de l'àrea de joc.


El joc està basat en el que ha creat OttoBotCode (vegeu el seu repositori més avall), al qual li he afegit algunes funcionalitats programades amb WinsForms i una base de dades per tal de fer-lo paregut a un sistema Arcade. He fet aquest joc per tal d'aprendre C#. És la primera vegada que faig servir tant C# com WinsForms o WPF, així que perdoneu si hi ha alguna incorrecció.

Peces
-----

Les set peces de Tetris Worlds. Tot i que les formes respecte al joc original no varien, els colors sí que ho fan.
Hi ha diferents versions del joc. L'original té set peces diferents. Llicències posteriors li van afegir formes suplementàries i hi ha fins i tot algunes versions tridimensionals.

Les peces s'assemblen a algunes de les lletres de l'abecedari (segons els colors de la imatge); la cian s'assembla a una I, la blava a una J, la taronja a una L, la groga a una O, la verda a una S, la lila a una T i la vermella a una Z; tot i que hi ha noms alternatius.

La versió original disposava de les peces ajuntades directament, sense diferenciar els blocs entre si, en canvi en les versions més modernes cada bloc està representat per un quadrat semblant a una rajola de xocolata, amb ombrejos inclosos per donar-li un toc de realisme.

Instructions
------------

The controls are typical of Tetris:
* <kbd>←</kbd> and <kbd>→</kbd>: Move the tetromino,
* <kbd>↑</kbd>: Rotate (clockwise) the tetromino,
* <kbd>↓</kbd>: Move tetromino down,
* <kbd>Z</kbd>: Rotate (counterclockwise) the tetromino
* <kbd>S</kbd>: Save tetromino
* <kbd>space</kbd>: Drop bottom the tetromino

  
Demo
----
![Video_221024131556](https://user-images.githubusercontent.com/55920937/197515175-edbd4f31-5b15-4556-a895-d14233eddce7.gif)


Screenshots
----------
![tetris1](https://user-images.githubusercontent.com/55920937/197514963-84b3556d-4ecb-4a4b-bc6b-fa0c512b3cd0.PNG)
![tetris2](https://user-images.githubusercontent.com/55920937/197514976-31324e65-7da5-4ed6-a827-0fbc7e7006f8.PNG)
![tetris3](https://user-images.githubusercontent.com/55920937/197514987-1426f5b6-359b-447e-bef5-1d6530d8325d.PNG)
![tetris4](https://user-images.githubusercontent.com/55920937/197514994-7cea51b4-8aa5-4e9f-a624-d1bc743c2c7b.PNG)

See also
--------
- [OttoBotCode Tetris Game](https://github.com/OttoBotCode/Tetris-Game)
- [System Data SQLclient Official Page](https://learn.microsoft.com/es-es/dotnet/api/system.data.sqlclient?view=dotnet-plat-ext-6.0)
- [.NET Official Page](https://learn.microsoft.com/es-es/dotnet/?view=dotnet-plat-ext-6.0)

License
-------
Apache License 2.0
