const apiUrl = 'http://localhost:5000/api/order'; // Update with the actual API URL

function loadOrders() {
    fetch(apiUrl)
        .then(response => response.json())
        .then(orders => {
            const ordersTable = document.getElementById('ordersTable').getElementsByTagName('tbody')[0];
            ordersTable.innerHTML = ''; // Clear the table first
            orders.forEach(order => {
                let row = ordersTable.insertRow();
                let cell1 = row.insertCell(0);
                let cell2 = row.insertCell(1);
                let cell3 = row.insertCell(2);
                let cell4 = row.insertCell(3);

                cell1.innerHTML = order.orderId;
                cell2.innerHTML = order.customer.name; // Adjust depending on actual data structure
                cell3.innerHTML = JSON.stringify(order.orderDetails);
                cell4.innerHTML = `<button onclick="deleteOrder(${order.orderId})">Delete</button>`;
            });
        })
        .catch(error => console.error('Unable to load orders.', error));
}

function submitOrder() {
    const orderData = {
        customerName: document.getElementById('customerName').value,
        orderDetails: JSON.parse(document.getElementById('orderDetails').value)
    };

    fetch(apiUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(orderData)
    })
        .then(response => response.json())
        .then(() => {
            document.getElementById('orderForm').reset();
            loadOrders(); // Reload the list
        })
        .catch(error => console.error('Unable to add order.', error));
}

function updateOrder() {
    const orderId = document.getElementById('orderId').value;
    const orderData = {
        orderId: orderId,
        customerName: document.getElementById('customerName').value,
        orderDetails: JSON.parse(document.getElementById('orderDetails').value)
    };

    fetch(`${apiUrl}/${orderId}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(orderData)
    })
        .then(() => {
            document.getElementById('orderForm').reset();
            loadOrders(); // Reload the list
        })
        .catch(error => console.error('Unable to update order.', error));
}

function deleteOrder(orderId) {
    fetch(`${apiUrl}/${orderId}`, {
        method: 'DELETE'
    })
        .then(() => loadOrders()) // Reload the list
        .catch(error => console.error('Unable to delete order.', error));
}

document.addEventListener('DOMContentLoaded', function () {
    loadOrders(); // Load orders when the page is ready
});
