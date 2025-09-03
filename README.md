# CoffeeMaker

Ein Kata, das sich auf Dependency Injection (DI) und insbesondere auf das Thema Lifetime und Scope konzentriert.

## Zielsetzung

Ihr habt eine Anwendung, die eine Kaffeemaschine simuliert. Die Kaffeemaschine benötigt verschiedene Abhängigkeiten:

- **WaterSupply:** Stellt Wasser bereit
- **Heater:** Erwärmt Wasser
- **Bean Reservoir:** Enhält Kaffeebohnen
- **Grinder:** Mahlt Kaffeebohnen

Die Herausforderung besteht darin, zu entscheiden, welche dieser Abhängigkeiten einen `Singleton`, einen `Scoped` oder einen `Transient` Lifetime erhalten sollen.

## Vorgehen

1. Überblick gewinnen, siehe `Program` und `DemoBaristaTests`.
2. Implementiere alle Komponenten.
3. Überlegt euch für jede Komponente, welchen Lifetime-Typ sie haben sollte und warum.
5. Überlegt euch, wie ihr die Wahl der Lifetimes verifiziert. 
6. Implementiere die DI-Konfiguration entsprechend.
7. Prüft eure Implementierung.
