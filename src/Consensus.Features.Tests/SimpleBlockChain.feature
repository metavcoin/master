Feature: Simple blockchain actions

  Scenario: Same tx is put in the main chain twice
    Given tx1 locks 100 metavcoin to key1
    And genesis has tx1

    And tx2 has the input tx1 index 0
    And tx2 locks 100 metavcoin to key2
    
    When signing tx2 with key1
    And validating block bk1 containing tx2 extending tip
    And validating block bk2 containing tx2 extending tip
    Then tip should be bk1

  Scenario: Simple reorg
    Given tx1 locks 100 metavcoin to key1
    And genesis has tx1

    And tx2 has the input tx1 index 0
    And tx2 locks 10 metavcoin to tx2_key1
    And tx2 locks 90 metavcoin to tx2_key2
    When signing tx2 with key1
    And validating block bk1 containing tx2 extending tip
    Then tip should be bk1
    
    When validating block bk2 containing tx2 extending genesis

    Given tx3 has the input tx2 index 0
    And tx3 locks 10 metavcoin to tx3_key1
    When signing tx3 with tx2_key1
    When validating block bk3 containing tx3 extending bk2
    Then tip should be bk3
    