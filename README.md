# LadaSellGroup

## API LAdaStore :

`POST /api/token`
raw data body
~~~~
{
	"Email": "addr@email.com",
	"Password": "*******"
}
~~~~

Response

`eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1NTkzMzQ1MzQsImlzcyI6Imh0dHA6Ly95b3VyZG9tYWluLmNvbSIsImF1ZCI6Imh0dHA6Ly95b3VyZG9tYWluLmNvbSJ9.q_MFNIbr9e26wG1YNbKw8HYgYsrDBNHcn1qooWLYqpw`

`GET /api/apicar`

~~~~
[
    {
        "carType": "Berline",
        "userID": 1,
        "carModelID": 1,
        "year": "2018",
        "kilometers": 24,
        "description": "blanla",
        "picture": "iVBORw0KGgoAAAANSUhEUgAAALQAAAC0CAIAAACyr5FlAAADNElEQVR4nOzcv2redRiH4aZ525damlbfxLQOQqNCixQEcXZxFAdx9RxEJxddXPUEnMRNZ/EQBIcuTgUT0Fi1VPzXGkqkifEA7ukpCHJdex8+hTvf6ZcsPnz75VMzP96+M7xwYmt7Nbxwe//n+YzV5sXhhQsbG/MZe7vfDS/s7Dw9n3F6foL/K3GQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcpMUP+z8NT2xvb853rB5/Ynhh4/yF+Yyzy7PDC7//+cd8xmKxPrxw8NfBfIaXgyQOkjhI4iCJgyQOkjhI4iCJgyQOkjhI4iCJgyQOkjhI4iCJgyQOkjhI4iCJgyQO0mK5XA5PXLo0/WPyJza3nhxeWJuPOHVqfX36OwHHa49gyJWXrgwv3P3l7nyGl4MkDpI4SOIgiYMkDpI4SOIgiYMkDpI4SOIgiYMkDpI4SOIgiYMkDpI4SOIgiYO0uDj+dny1Ws13PPvMc8MLR4eH8xn3f70zvPBwc2s+Y+fq1eGFvb3d+QwvB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcpMVTly8PT7zx1qfzHS9ee3V44bNPXp/PeHB4MLzwzns35zO+/f7j4YVbH705n+HlIImDJA6SOEjiIImDJA6SOEjiIImDJA6SOEjiIImDJA6SOEjiIImDJA6SOEjiIC1u3Lj+X2/4181bXwwvHN5/ZT7j8MG94YXd/a/mM+auP39tfsTLQRIHSRwkcZDEQRIHSRwkcZDEQRIHSRwkcZDEQRIHSRwkcZDEQRIHSRwkcZDEQRIHae3rz98dnvj73m+PYMeZM8ML68vH5jOOj46HF06vHc1nnPxvpv9+uZyP8HKQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQxEESB0kcJHGQFmfPnR+eOLeYfjh+4uH69HvrF157fz5j7psvP5gfOR7/0K6dXsxneDlI4iCJgyQOkjhI4iCJgyQOkjhI4iCJgyQOkjhI4iCJgyQOkjhI4iCJgyQOkjhI4iD9EwAA//9xsUorYDi6hAAAAABJRU5ErkJggg==",
        "id": 2
    }
]
~~~~
