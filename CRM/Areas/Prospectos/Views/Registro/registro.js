$(document).ready(function () {
    if ($("#archivosprospecto").length > 0) {
        Dropzone.options.dropzoneForm = {
            maxFiles: 25,
            Init: function () {
                this.on("maxfilesexceeded", function (data) {
                    debugger;
                    var res = eval('(' + data.xhr.responseText + ')');
                });
            }
        }
    }

    $("#btncancelar").click(function () {
        swal(
            {
                title: "Se pueden Perder Los cambios",
                text: "¿Estas seguro que desea salir?",
                type: "warning",
                showCancelButton: true,
                confirmButtonColor: "#DD6B55",
                confirmButtonText: "Si Deseo salir",
                closeOnConfirm: false
            },
            function () {
                window.location.href = "/Prospectos"
            }
        );
        //window.location.href = "/Prospectos";
    });

    toastr.options = {
        "closeButton": true,
        "debug": false,
        "progressBar": true,
        "preventDuplicates": false,
        "positionClass": "toast-top-right",
        "onclick": null,
        "showDuration": "400",
        "hideDuration": "1000",
        "timeOut": "7000",
        "extendedTimeOut": "3500",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
});


function Validate() {
    $("#btnguardar").attr('disabled', 'disabled');
    return true;
}

function termino(xhr, status) {
    $("#btnguardar").removeAttr('disabled');
    if (xhr.responseJSON.status == 1)
    {
        var id = $("#id").val();
        if (id == "00000000-0000-0000-0000-000000000000") {
            $("#id").val(xhr.responseJSON.id);
        }
        toastr["success"]("Prospecto Guardado Exitosamente");
        

        //Se guardo correctamente
    } else {        
        //Sucedio un error
        toastr["error"]("Error al momento de guardar");
    }    
}