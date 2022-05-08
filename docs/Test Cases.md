# Test Cases

## Scenario 1: Valid input

**Test Id**: TC01  
**Design By**: Rafael Sánchez  
**Review By**: Lorenzo Solano

### Variables
@ssn = 402-01-7615

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "Número de Seguridad Social válido"      |   Message "Número de Seguridad Social válido"    | pass |

## Scenario 2: Invalid input, bad format

**Test Id**: TC02  
**Design By**: Rafael Sánchez  
**Review By**: Lorenzo Solano

### Variables
@ssn = 402-000076176-1

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "El número de Seguridad Social debe tener el formato xxx-xx-xxxx"      |  Message "El número de Seguridad Social debe tener el formato xxx-xx-xxxx"   | pass |

## Scenario 3: Invalid input, incorrect numbers

**Test Id**: TC03  
**Design By**: Rafael Sánchez  
**Review By**: Lorenzo Solano

### Variables
@ssn = 402-00-5711

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "El Número de Seguridad Social no puede empezr con 000, 666 o entre 900 y 999"      |  Message "El Número de Seguridad Social no puede empezr con 000, 666 o entre 900 y 999"  | pass |

### Variables
@ssn = 666-00-5711

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "El Número de Seguridad Social no puede empezr con 000, 666 o entre 900 y 999"      | Message "El Número de Seguridad Social no puede empezr con 000, 666 o entre 900 y 999"   | pass |
