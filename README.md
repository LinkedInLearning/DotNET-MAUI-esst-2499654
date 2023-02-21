# .NET MAUI Grundkurs

Dies ist das Repository für den **LinkedIn Learning** Kurs `[.NET MAUI Grundkurs]`. Den gesamten Kurs finden Sie auf [LinkedIn Learning][lil-course-url].

![image](https://user-images.githubusercontent.com/71371373/220305439-7c068c65-3cff-4683-aadd-59dfda57abd9.png)

Sie möchten Apps entwickeln, die sowohl mobil unter Android und iOS als auch auf dem Desktop unter macOS und Windows nativ lauffähig sind? Der erfahrene Softwareentwickler und langjährige Microsoft-MVP André Krämer führt Sie in diesem LinkedIn Learning Kurs Schritt für Schritt in die Welt der Cross-Plattform-Entwicklung mit .NET MAUI und C# ein. Zum Start sehen Sie, wie Sie den Xamarin-Nachfolger auf Ihrem Windows-PC und Ihrem Mac installieren und wie Sie die Entwicklungsumgebungen nutzen. Im Laufe des Kurses programmieren Sie eine Beispiel-App für ein fiktives Restaurant und vertiefen dabei das erworbene Wissen. Mit Hilfe von Challenge/Solutions-Einheiten können Sie das Gelernte immer wieder überprüfen und Ihre Lösung mit der Ihres Trainers vergleichen.

## Anleitung

Dieses Repository hat Branches für jedes Video im Kurs. Verwenden Sie das Ausklappmenü "Branch: ..." in GitHub um zwischen den unterschiedlichen Branches hin und her zu wechseln bzw. um bei einem spezifischen Status einzusteigen. Oder Sie fügen `/tree/BRANCH_NAME` der URL hinzu um direkt in den gewünschten Branch zu wechseln.

## Branches

Die Git Branches sind passend zu den Videos im Kurs strukturiert. Die Namenskonvention lautet `Kapitel#_Video#`. Der Branch `02_03` beinhaltet zum Beispiel die Übungen für das dritte Video im zweiten Kapitel. 
Einige Branches haben einen Anfangsstatus (`b`) für "beginning" und einen Endstatus (`e`). Der Branch mit dem `e` am Ende beinhaltet in diesem Fall stets den Code der am Ende des Videos zu sehen ist. Der `master` Branch beinhaltet den initialen Quellcode und wird nicht für die Übungen innerhalb des Kurses genutzt.

Wenn Sie von einem Branch nach Änderungen zum nächsten Branch wechseln, erhalten Sie möglicherweise die folgende Meldung:

```
error: Your local changes to the following files would be overwritten by checkout:        [files]
Please commit your changes or stash them before you switch branches.
Aborting
```

Dieses Problem lösen Sie wie folgt:
    Add changes to git using this command: git add .
    Commit changes using this command: git commit -m "some message"

## Installation

1. Um diese Übungsdateien nutzen zu können, müssen Sie folgendes installiert haben:
   - Visual Studio 2022, Version 17.4 oder höher. Die Beispiele können mit jeder verfügbaren Edition (Community, Professional, Enterprise) bearbeitet werden.
   - Falls Sie über einen Mac verfügen, dann müssen Sie dort Visual Studio for Mac 2022, Version 17.4 oder höher, und XCode installieren.
2. Klonen Sie das Repository in Ihre lokale Maschine unter Verwendung von terminal (Mac), CMD (Windows) oder ein anderes Werkzeug mit grafischer Bedienoberfläche wie SourceTree.
3. Um Ihre App auch für iOS zu kompilieren benötigen Sie einen Mac. Ohne Mac können Sie dem Training zwar komplett folgen, aber nur die Android- und Windows-App kompilieren.

### Autor

**André Krämer**

_Geschäftsführer der Quality Bytes GmbH_

Sehen Sie sich andere Kurse des Autors auf [LinkedIn Learning](https://www.linkedin.com/learning/instructors/andre-kramer) an.

[0]: # (Replace these placeholder URLs with actual course URLs)
[lil-course-url]: https://www.linkedin.com/learning/dot-net-maui-grundkurs/native-apps-mit-dot-net-maui-und-c-sharp-entwickeln
[lil-thumbnail-url]: https://cdn.lynda.com/course/2875095/2875095-1615224395432-16x9.jpg
