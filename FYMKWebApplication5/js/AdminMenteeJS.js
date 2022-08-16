

const Name = document.querySelector('.Fname');

function workloadFunction(idvalue) {
    @foreach(var project in Model.activeProjects)
    {
        @if (project.id == idvalue) {
            //rest of code
        }
    }


Name.addEventListener('click', () => {
    console.log(Name.value)
    alert(Name.value)
})