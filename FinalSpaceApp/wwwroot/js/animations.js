
//Animate through gary images for sprite
//window.startImageAnimation = (imageCount) => {
//    let imageIndex = 1;
//    const imageElement = document.getElementById('gary-image');

//    setInterval(() => {
//        imageIndex = (imageIndex % imageCount) + 1;
//        imageElement.src = `/img/gary/gary` + String(imageIndex).padStart(2, '0') + `.png`;
//    }, 150);
//};
/*window.startImageAnimation(7); */


//function typeText(elementId, text, speed) {
//    let i = 0;
//    const element = document.getElementById(elementId);
//    element.innerHTML = ""; // Clear existing text

//    function typeCharacter() {
//        if (i < text.length) {
//            element.innerHTML += text.charAt(i);
//            i++;
//            setTimeout(typeCharacter, speed);
//        }
//    }
//    typeCharacter();
//}

//function clearText(elementId) {
//    document.getElementById(elementId).innerHTML = ""; // Clear existing text
//}
function typeTextSequentially(lines, interval) {
    let index = 0;

    function typeLine(line) {
        const element = document.getElementById(line.elementId);
        if (line.type === "text") {
            let charIndex = 0;
            function typeChar() {
                if (charIndex < line.text.length) {
                    element.innerHTML += line.text.charAt(charIndex);
                    charIndex++;
                    setTimeout(typeChar, interval);
                } else {
                    element.innerHTML += "<br/>"; // Add a line break after each line
                    index++;
                    if (index < lines.length) {
                        typeLine(lines[index]);
                    } // else {
                        // All lines typed, invoke the completion callback
                    //    DotNet.invokeMethodAsync('TheFinalSpaceApp', 'OnTypingComplete');
                    //}
                }
            }

            typeChar();
        } else if (line.type === "image") {
            const imgElement = document.getElementById(`img${line.id}`);
            if (imgElement) {
                imgElement.src = line.imageUrl; // Set the image source
                imgElement.alt = line.text;
            }
            index++;
            if (index < lines.length) {
                typeLine(lines[index]);
            }

        } else if (line.type === "input") {
            const inputElement = document.getElementById(`line${line.id}`);
            if (inputElement) {
                inputElement.style.display = ""; // 'block'; // Unhide the input element
            }
            index++;
            if (index < lines.length) {
                typeLine(lines[index]);
            }        
        } else if (line.type === "button") {
            const buttonElement = document.getElementById(`line${line.id}`);
            if (buttonElement) {
                buttonElement.style.display = ""; 
            }
            index++;
            if (index < lines.length) {
                typeLine(lines[index]);
            }
        } else {
            index++;
            if (index < lines.length) {
                typeLine(lines[index]);
            }
        }
    }

    if (lines.length > 0) {
        typeLine(lines[0]);
    }
}

