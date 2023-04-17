var TesteAPI = function () {

    var drawPos1 = function () {
        $("#pos1").keyup(function () {
            var canvas = document.getElementById('myCanvas1');
            var res = $("#pos1").val().replace(/[^-]/g, "");
            var res1 = $("#pos1").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);                
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 70);//ponta da esquerda
                    ctx.lineTo(215, 70);//ponto da direita
                    ctx.lineTo(210, 82);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(210, 70);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                }else if(res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 16);//ponta da esquerda
                    ctx.lineTo(215, 16);//ponto da direita
                    ctx.lineTo(210, 4);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 10);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                }  else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }              
            }
        })      
    }
    var drawPosE1 = function () {
        $("#posE1").keyup(function () {
            var canvas = document.getElementById('myCanvasE1');
            var res = $("#posE1").val().replace(/[^-]/g, "");
            var res1 = $("#posE1").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(245, 35);//ponta da esquerda
                    ctx.lineTo(255, 40);//ponto da direita
                    ctx.lineTo(245, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(250, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(185, 35);//ponta da esquerda
                    ctx.lineTo(175, 40);//ponto da direita
                    ctx.lineTo(185, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(180, 40);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPos2 = function () {
        $("#pos2").keyup(function () {
            var canvas = document.getElementById('myCanvas2');
            var res = $("#pos2").val().replace(/[^-]/g, "");
            var res1 = $("#pos2").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(245, 35);//ponta da esquerda
                    ctx.lineTo(255, 40);//ponto da direita
                    ctx.lineTo(245, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(250, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(185, 35);//ponta da esquerda
                    ctx.lineTo(175, 40);//ponto da direita
                    ctx.lineTo(185, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(180, 40);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPos3 = function () {
        $("#pos3").keyup(function () {
            var canvas = document.getElementById('myCanvas3');
            var res = $("#pos3").val().replace(/[^-]/g, "");
            var res1 = $("#pos3").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 70);//ponta da esquerda
                    ctx.lineTo(215, 70);//ponto da direita
                    ctx.lineTo(210, 82);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(210, 70);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 16);//ponta da esquerda
                    ctx.lineTo(215, 16);//ponto da direita
                    ctx.lineTo(210, 4);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 10);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })      
    }
    var drawPosE3 = function () {
        $("#posE3").keyup(function () {
            var canvas = document.getElementById('myCanvasE3');
            var res = $("#posE3").val().replace(/[^-]/g, "");
            var res1 = $("#posE3").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(245, 35);//ponta da esquerda
                    ctx.lineTo(255, 40);//ponto da direita
                    ctx.lineTo(245, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(250, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(185, 35);//ponta da esquerda
                    ctx.lineTo(175, 40);//ponto da direita
                    ctx.lineTo(185, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(180, 40);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPos4 = function () {
        $("#pos4").keyup(function () {
            var canvas = document.getElementById('myCanvas4');
            var res = $("#pos4").val().replace(/[^-]/g, "");
            var res1 = $("#pos4").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(245, 35);//ponta da esquerda
                    ctx.lineTo(255, 40);//ponto da direita
                    ctx.lineTo(245, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(250, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(185, 35);//ponta da esquerda
                    ctx.lineTo(175, 40);//ponto da direita
                    ctx.lineTo(185, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(180, 40);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPos5 = function () {
        $("#pos5").keyup(function () {
            var canvas = document.getElementById('myCanvas5');
            var res = $("#pos5").val().replace(/[^-]/g, "");
            var res1 = $("#pos5").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(245, 35);//ponta da esquerda
                    ctx.lineTo(255, 40);//ponto da direita
                    ctx.lineTo(245, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(250, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(185, 35);//ponta da esquerda
                    ctx.lineTo(175, 40);//ponto da direita
                    ctx.lineTo(185, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(180, 40);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPos6 = function () {
        $("#pos6").keyup(function () {
            var canvas = document.getElementById('myCanvas6');
            var res = $("#pos6").val().replace(/[^-]/g, "");
            var res1 = $("#pos6").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {    
                    var ctx = canvas.getContext('2d');
                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 16);//ponta da esquerda
                    ctx.lineTo(215, 16);//ponto da direita
                    ctx.lineTo(210, 4);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 10);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');
                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 70);//ponta da esquerda
                    ctx.lineTo(215, 70);//ponto da direita
                    ctx.lineTo(210, 82);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(210, 70);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPosE6 = function () {
        $("#posE6").keyup(function () {
            
            var canvas = document.getElementById('myCanvasE6');
            var res = $("#posE6").val().replace(/[^-]/g, "");
            var res1 = $("#posE6").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(245, 35);//ponta da esquerda
                    ctx.lineTo(255, 40);//ponto da direita
                    ctx.lineTo(245, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(250, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(185, 35);//ponta da esquerda
                    ctx.lineTo(175, 40);//ponto da direita
                    ctx.lineTo(185, 45);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(180, 40);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }
    var drawPos7 = function () {
        $("#pos7").keyup(function () {
            var canvas = document.getElementById('myCanvas7');
            var res = $("#pos7").val().replace(/[^-]/g, "");
            var res1 = $("#pos7").val().replace(/[^0-9]/g, "");
            if (canvas.getContext) {
                canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                if (res == "-") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 70);//ponta da esquerda
                    ctx.lineTo(215, 70);//ponto da direita
                    ctx.lineTo(210, 82);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 40);
                    ctx.lineTo(210, 70);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else if (res1 != "") {
                    var ctx = canvas.getContext('2d');

                    ctx.beginPath();
                    //desenha triangulo
                    ctx.moveTo(205, 16);//ponta da esquerda
                    ctx.lineTo(215, 16);//ponto da direita
                    ctx.lineTo(210, 4);//ponta de cima
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.fill();

                    //desenharlinha
                    ctx.moveTo(210, 10);
                    ctx.lineTo(210, 40);
                    ctx.fillStyle = "rgb(255,0,0)"
                    ctx.strokeStyle = "rgb(255, 0, 0)"
                    ctx.stroke();
                } else {
                    canvas.getContext('2d').clearRect(0, 0, canvas.getContext('2d').canvas.width, canvas.getContext('2d').canvas.height);
                }
            }
        })
    }




    return {
        TesteIndex: function () {
            drawPos1();
            drawPosE1();
            drawPos2();
            drawPos3();
            drawPosE3();
            drawPos4();
            drawPos5();
            drawPos6();
            drawPosE6();
            drawPos7();
            
        }
    }
}();