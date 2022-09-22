# Lern-Bericht
Christian Aeschlimann
## Einleitung

Im Projekt LA1100 mussten wir mit C# in Visual Studio ein kleines Spiel programmieren, bei welchem man Zahlen erraten konnte und wenn man sie richtig erraten 
hat, hat man gewonnen.

## Was habe ich gelernt?

In meinem Projekt habe ich gelernt, dass man, wenn man z. B. bei "if" schleifen ein ToLower hinter den Datentyp schreibt, dass dann, wenn ein Text eingegeben 
werden muss, da nicht auf die Gross-Kleinschreibung geachtet wird

## Beschreibung

```csharp
  Console.WriteLine("Wollen sie das Spiel auf einfach oder schwer spielen?"); 
            string niveau = Convert.ToString(Console.ReadLine()); 
            if (niveau.ToLower() == "schwer") 
            {
                goto schwer;



            }
            else if (niveau.ToLower() == "einfach")
            {
                goto einfach;



            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
                
                goto Level;

            }
```
![Beispiel](https://user-images.githubusercontent.com/111046353/191692267-25a94adf-f996-4e0e-8c17-ac8585d009e9.gif)



## Verifikation

Beim Code sieht man sehr gut wie man dies anwenden kann, wobei man beim GIF sieht, dass man da mit der Gross-Kleinschreibung spielen kann wie man will und es 
trotzdem erkannt wird

# Reflexion zum Arbeitsprozess

Am Anfang hatte, ich mühe mit dem Online Unterricht, da es für mich eine grosse Umstellung war. Aber nach einer Zeit ging es immer besser.

Ich habe mich mit Ideen übernommen, wollte dann noch eine externe Datenbank miteinbeziehen. Aber bis ich gemerkt habe, dass ich das einfach noch nicht kann, verging viel 
Zeit.

**VBV**: Das nächste Mal möchte ich, wenn ich wieder anspruchsvolle Ideen habe, schneller die Idee fallen lassen anstatt wie bei diesem Projekt viel Zeit daran zu
verlieren
