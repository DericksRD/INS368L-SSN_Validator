# Test Cases

## Scenario 1: Valid input

**Test Id**: TC01  
**Design By**: Rafael Sánchez  
**Review By**: Lorenzo Solano

### Variables
@ssn = 402-01-7615

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "The Social Security Number is valid"      |          |  |

## Scenario 2: Invalid input, bad format

**Test Id**: TC02  
**Design By**: Rafael Sánchez  
**Review By**: Lorenzo Solano

### Variables
@ssn = 402-000076176-1

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "The Social Security Number must have format xxx-xx-xxxx"      |          |  |

## Scenario 3: Invalid input, incorrect numbers

**Test Id**: TC03  
**Design By**: Rafael Sánchez  
**Review By**: Lorenzo Solano

### Variables
@ssn = 402-00-5711

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "The Social security number can't start with 000, 666, 999 or be follow by 00"      |          |  |

### Variables
@ssn = 666-00-5711

| Step # | Description | Expected Result | Actual Result | State |
|  ---:  |    :---:    |       :---:     |     :---:     | :---: |
| 1      | Insert @ssn | Message "The Social security number can't start with 000, 666, 999 or be follow by 00"      |          |  |
