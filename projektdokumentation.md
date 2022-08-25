# Projekt-Dokumentation

Aeschlimann Christian

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 25.08 | 0.0.1   | Heute habe ich die Grundlagen der Projektdokumentiation gelernt. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Der Spieler muss die von der Console vorgegebene Zahl erraten.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                        |
| ---- | --------------- | ---- | ----------------------------------  |
| US. 1| Muss            | FA   | Als ein Spieler möchte ich dass der Computer eine Zahl generiert damit das Spiel gespielt werden kann.|
| US. 2| Muss            | FA   | Als ein Spieler möchte ich dass ich die Zahl erraten kann damit ich auch gewinnen kann.|
| US. 3| Muss            | FA   | Als ein Entlwickler möchte ich dass die Spieler hinweise zur richtigen Zahl bekommen damit es für sie möglich ist mit möglichst wenigsten Versuchen zu gewinnen.|
| US. 4| Kann            | NFA  | Als ein Spieler möchte ich dass wenn ich die Zahl erraten habe das mir die Anzahl versuche angezeigt werden damit ich mich verbessern kann.|
| US. 5| Kann            | Quali| Als ein Spieler möchte ich dass das System falscheingaben erkennt damit es zu keinen Fehlern führen kann.|
| US. 6| Kann            | Rand | Als ein Spieler möchte ich dass es noch zusätzliche Funktionen gibt damit es nicht langweilig wird.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1   | Projekt gestartet  | Spiel starten        | Zahl wird generiert                  |
|  2   | Projekt gestartet, Zahl generiert             | Zahl eingabe (raten)        | Diese Zahl ist leider falsch                   |
|  3   | Projekt gestartet, Zahl generiert             | Zahl eingabe (raten)        | Die gesuchte Zahl ist kleiner                  |
|  4   | Projekt gestartet, Zahl generiert             | Eingabe der richtigen Zahl        | Glückwunsch! sie haben es mir 2 Versuchen geschafft die Zahl heraus zu finden                  |
|  5   | Projekt gestartet, Zahl generiert             | Falsche eingabe        | Sie können nur Zahlen zwischen 1 und 100 verwenden                  |
|  6   | Projekt gestartet, Zahl generiert             | neunzig        | Die Zahl ist kleiner als 90                   
| 6.1  | Projekt gestartet, Zahl generiert             | Eingabe der richtigen Zahl        | Glückwunsch! sie haben die Zahl erraten, sie sind platz 2 mit 3 Versuchen!                  |


### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111046353/186625517-648ab028-12bc-44f8-98e7-bbf1b738b005.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  1.9  |    Ich    | Computer generiert Zahl             |     45min     |
| 2.A  |  1.9  |    Ich    | Benutzer kann raten             |     45min     |
| 3.A  |  1.9  |    Ich    | Hinweis grösser             |     45min     |
| 4.A  |  1.9  |    Ich    | Hinweis kleiner             |     45min     |
| 5.A  |  8.9  |    Ich    | Richtige Zahl erraten             |     45min     |
| 6.A  |  8.9  |    Ich    | Ratversuche             |     45min     |
| 7.A  |  8.9  |    Ich    | Fehleingaben             |     45min     |
| 8.A  |  8.9  |    Ich    | Schöner Gestalten 1            |     45min     |
| 9.A  |  15.9 |    Ich    | Schöner Gestalten 2             |     45min     |
| 10.A |  15.9 |    Ich    | Besten liste             |     45min     |
| 11.A |  15.9 |    Ich    | Mehrere Level              |     45min     |
| 12.A |  15.9 |    Ich    |               |     45min     |


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Ich habe mich dazu entschieden meherere Level zu machen und das ganze so schön wie möglich zu gestalten.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
