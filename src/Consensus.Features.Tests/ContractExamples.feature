Feature: Contract Examples

  Scenario: Token contract - buy
    Given utxoset
      | Tx   | Key     | Asset | Amount |
      | tx-1 | utxoKey | metavcoin   |    100 |
    And txIn has the input tx-1 index 0
    And txIn locks 10 metavcoin to outKey
    When executing ../../../../ContractExamples/Token.fst on txIn returning txBuy with
      | Argument      | Value            |
      | Command       | buy              |
      | ReturnAddress | buyAddressKey    |
    And signing txBuy with utxoKey
    Then txBuy should pass validation
    And txBuy should lock 9000000000 ../../../../ContractExamples/Token.fst to buyAddressKey

    # TODO: implement persisting utxo to transient DB to support following test
#  Scenario: Token contract - redeem
#    Given utxoset
#      | Tx   | Key          | Asset                                  | Amount      |
#      | tx-1 | utxometavcoinKey   | metavcoin                                    |         100 |
#      | tx-2 | utxoTokenKey | ../../../../ContractExamples/Token.fst | 10000000000 |
#    And txIn has the input tx-1 index 0
#    And txIn has the input tx-2 index 0
#    When executing ../../../../ContractExamples/Token.fst on txIn returning txRedeem with
#      | Argument      | Value            |
#      | Command       | redeem           |
#      | ReturnAddress | redeemAddressKey |
#    And signing txRedeem with utxometavcoinKey,utxoTokenKey
#    Then txRedeem should pass validation
#    And txRedeem should lock 10 metavcoin to redeemAddressKey

  Scenario: Faucet contract - init
    Given utxoset
      | Tx   | Key     | Asset | Amount |
      | tx-1 | utxoKey | metavcoin   |    100 |
    And txIn has the input tx-1 index 0
    When executing ../../../../ContractExamples/Faucet.fst on txIn returning txInit with
      | Argument      | Value            |
      | Command       | init             |
    And signing txInit with utxoKey
    Then txInit should pass validation
    And txInit should lock 100 metavcoin to ../../../../ContractExamples/Faucet.fst
