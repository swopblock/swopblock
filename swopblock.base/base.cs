using System;

namespace SwopblockBase
{
    public record Values();

    public record Addresses();

    public record Transfers(Transfers Previous, Addresses Address, Values Value);

    public record TransactionHashes(Transfers Last);

    public record Signatures(TransactionHashes TransactionHash, Transfers Last);

    public record Transactions(TransactionHashes Hash, Signatures Signature, Transfers Last);

    public record MarketableTransactionHashes(Transactions Transaction, MarketableTransactions InputMarket, MarketableTransactions OutputMarket);

    public record MarketableTransactions(MarketableTransactionHashes Hash, Transactions Transaction, MarketableTransactions InputMarket, MarketableTransactions OutputMarket);


}
