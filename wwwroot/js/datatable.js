window.initFilterTable = () => {
    const table = document.getElementById("filter-table");
    if (!table || typeof simpleDatatables === "undefined") return;

    new simpleDatatables.DataTable(table, {
        tableRender: (_data, table, type) => {
            if (type === "print") return table;

            const tHead = table.tHead;
            const headerRow = tHead.rows[0];

            const filterRow = document.createElement("tr");
            filterRow.className = "search-filtering-row";

            [...headerRow.cells].forEach((_, index) => {
                const th = document.createElement("th");
                const input = document.createElement("input");

                input.type = "search";
                input.className = "datatable-input";
                input.dataset.columns = `[${index}]`;

                th.appendChild(input);
                filterRow.appendChild(th);
            });

            tHead.appendChild(filterRow);
            return table;
        }
    });
};
