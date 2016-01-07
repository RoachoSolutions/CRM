$(document).ready(function () {
    $("#btnAgregarNota").click(function () {
        debugger;
        var nota = $("#txtnota").val();
        var id = $("#id").val();
        $.ajax({
            url: urlbase + "Prospectos/Detalle/AgregarNota",
            method:"POST",
            data: {
                id: id,
                nota: nota
            },
            success: function (response, status, xhr) {
                //$("#GrdMovimientos").replaceWith(response);
                try {
                    var datos = response;
                    if (typeof (response) !== "object") {
                        datos = JSON.parse(response);
                    }
                    
                    if (datos.estatus == 1) {
                        alert("Se guardo exitosamente");
                    } else {
                        alert(datos.error);
                    }
                } catch (ex) {
                    alert(ex.message);
                }
                

                
            },
            error: function( jqXHR, textStatus, errorThrown ){
                alert(errorThrown);
            }
        });
    });
});


function MostrarMasInfo() {
    $("#dvmore").toggle();
}