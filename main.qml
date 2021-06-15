import QtQuick 2.12
import QtQuick.Window 2.12
import "component"

Window {
    id: main_window
    width: Screen.width * 0.70
    height: Screen.height * 0.70
    visible: true
    title: qsTr("ArisNote")

    Rectangle {
        width: parent
        height: parent
        color: "#00595959"
        state: "empty"

        Front {
            id: front
        }

        Scribble {
            id: scrrible
        }

        states: [
            State {
                name: "front"
                PropertyChanges {
                    target: front

                }
            } ,
            State {
                name: "scribble"
                PropertyChanges {
                    target: scribble

                }
            }
        ]
    }
}


/*##^##
Designer {
    D{i:0;formeditorZoom:0.5}
}
##^##*/
