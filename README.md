# Programming assessment .NET (Backend developer)

##	Context van de taak:
Je ontwikkelt een API voor een fictief e-commercebedrijf dat producten en bestellingen beheert. De API moet meerdere entiteiten ondersteunen en businesslogica toepassen om gegevens consistent te houden.

##	Taakomschrijving:
Bouw een RESTful API met .NET Core die de volgende functionaliteiten biedt:

### Entiteiten en Relaties:
Een beschrijving van entiteiten en daarbij horende relaties.

*Product:*
| Field name | Field tyoe |
|--|--|
| Id | int |
| Name | string |
| Price | decimal |
| StockQuantity | int |

*Order:*
| Field name | Field tyoe |
|--|--|
| Id | int |
| CustomerName | string |
| OrderDate | DateTime |
| OrderItems | collection van OrderItem |

*OrderItem  (een product binnen een bestelling):*
| Field name | Field tyoe |
|--|--|
| ProductId | int |
| Quantity | int |

Relaties:
- Een bestelling (Order) kan meerdere OrderItems bevatten.
- Elk OrderItem verwijst naar één Product.

### Endpoints:
- GET /products: Haal een lijst met producten op.
- POST /products: Voeg een nieuw product toe (inclusief validaties).
- GET /orders: Haal een lijst met bestellingen op, inclusief gekoppelde producten.
- POST /orders: Plaats een nieuwe bestelling.
	-	Validaties:
		- Controleer of de bestelde producten voldoende voorraad hebben.
		- Verminder de voorraad van de betrokken producten bij het plaatsen van de bestelling.
		- Retourneer een foutmelding als een product onvoldoende voorraad heeft.
- GET /orders/{id}: Haal een specifieke bestelling op met alle bijbehorende details.

### Infrastructuur:
- Gebruik een in-memory database (bijvoorbeeld Dictionary, List) of een SQLite database om de gegevens in op te slaan.
- Schrijf de benodigde klassen en zorg ervoor dat de relatie tussen bestellingen, producten en items correct wordt gemodelleerd.

### Extra:
- Voeg Swagger-documentatie toe.
- Bonus: Voeg een mechanisme toe om rapporten te genereren:
	- Endpoint: GET /reports/stock-status.
	- Retourneer een overzicht van producten en hun huidige voorraadstatus.