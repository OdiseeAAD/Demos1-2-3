# Todo Applicatie

Vervolledig de todo applicatie

## Stap 1
Zorg in de code-behind van het MainWindow voor de nodige properties. We willen alles aan de hand van databinding doen. Volgende controls zullen een property moeten hebben in de code-behind:

* Textboxen (property type => string)
* DatePicker (property type => DateTime)
* ListView (property type => ObservableCollection)

## Stap 2
Voeg een click event aan de button. Wanneer op de knop geduwd wordt moet een nieuwe todo toegevoegd worden aan de listview. Maak hierbij gebruik van de ObservableCollection.

## Stap 3
Zorg ervoor dat wanneer er op een item in de lijst geklikt wordt, dat de gegevens in de textboxen en datepicker komen te staan.
Je kan dit doen aan de hand van een extra property die je bind aan SelectedItem van de Listbox.
Denk er ook aan om een onpropertyChanged event te triggeren.

## Stap 4
Zorg voor een custom layout in de listview. Waarbij je een item kan afvinken of aanvinken.

## Stap 5
Wanneer je een item selecteert en nadien op opslaan klikt, wordt het geselecteerde item gewijzigd.