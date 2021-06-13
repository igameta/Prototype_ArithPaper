import QtQuick 2.12
import QtQuick.Window 2.12
import "component"

Window {
    id: main_window
    width: 640
    height: 480
    visible: true
    title: qsTr("ArisNote")

    Rectangle {
        state: "front"
    }

    Rectangle {
        state: "scribble"
    }

}
