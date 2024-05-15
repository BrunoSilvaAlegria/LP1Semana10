LP1 Diagram by Bruno Alegria

``` mermaid

      classDiagram
      class Controller {          
      }

      class Player {    
      }

      class CompareByName {
      }

      class PlayerOrder {
            <<Enumeration>>
      }

      class IComparer {
            <<Interface>> 
      }

      class IComparable {
            <<Interface>> 
      }

      class IView {
            <<Interface>> 
      }

      class UglyView {
      }

      Controller --> IView
      Controller --> IComparer
      Controller --> PlayerOrder
      Controller o--> Player

      UglyView ..> PlayerOrder
      UglyView --> Controller
      UglyView o--> Player

      CompareByName ..> Player
      IView ..> Player

      IView <|.. UglyView
      IComparable <|.. Player
      IComparer <|.. CompareByName
```