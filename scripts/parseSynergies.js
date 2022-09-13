// Link: https://enterthegungeon.fandom.com/wiki/Synergies
function tableToJson(table) { 
    var data = [];
    for (var i=0; i<table.rows.length; i++) { 
        var tableRow = table.rows[i]; 
        var rowData = {};
        rowData['Name'] = tableRow.cells[0].innerText
        rowData['ItemGroups'] = [];
        for (var j=1; j<tableRow.cells.length; j++) {
            var gunTab = tableRow.cells[j].querySelector("table");
            if (gunTab == null) {
                rowData['Description'] = tableRow.cells[j].innerText;
                break;
            }
            var itemGroup = {}
            itemGroup['Type'] = 'All of the following:\n';
            var gunTabLabel = tableRow.cells[j].firstChild.textContent
            if (gunTabLabel !== "\n" && gunTabLabel !== "") {
                itemGroup['Type'] = tableRow.cells[j].firstChild.textContent
            }
            itemGroup['Items'] = []
            
            var gunRefs = tableRow.cells[j].querySelectorAll("a");
            for (var gunRef of gunRefs) {
                if (gunRef.textContent !== "") {
                    itemGroup['Items'].push(gunRef.textContent);
                }
            }
            rowData['ItemGroups'].push(itemGroup);
        }
        
        data.push(rowData); 
    } 
    return data; 
}

var table = document.querySelector("tbody")
var json = tableToJson(table)
console.log(JSON.stringify(json))
