// SPDX-License-Identifier: GPL-2.0

using System;

namespace SwopblockBase
{
    public record Values(UInt64 FeeFaceValue, Int64 TradingFaceValue, UInt64 MarketQuoteLimitValue, UInt64 MarketFaceLimitValue);

    public record Addresses();

    public record Transfers(Transfers PreviousOfTransaction, Addresses Address, Values Value);

    public record TransactionHashes(Transfers LastOfTransaction);

    public record Signatures(TransactionHashes TransactionHash, Transfers LastOfTransaction);

    public record Transactions(TransactionHashes Hash, Signatures Signature, Transfers LastOfTransaction);

    public record MarketableTransactionHashes(Transactions Transaction, MarketableTransactions InputMarket, MarketableTransactions OutputMarket);

    public record MarketableTransactions(UInt64 MarketQuoteValue, UInt64 MarketFaceValue, MarketableTransactionHashes Hash, Transactions Transaction, MarketableTransactions InputMarket, MarketableTransactions OutputMarket);

    public record DeliverableTransactions(DeliverableTransactions PreviousDeliverableInputSet, MarketableTransactions[] MarketedTransactions);

    public record VerifiableTransactions(VerifiableTransactions PreviousVerificationInputSet, DeliverableTransactions[] DeliveredTransactions);

    public record ArchiveableTransactions(ArchiveableTransactions PreviousArchiveableInputSet, VerifiableTransactions[] VerifiedTransactions);

    public record OffLineTransactions(OffLineTransactions PreviousHistoryOfTransactions, ArchiveableTransactions[] ArchivedTransactions);

    public record OnlineTransactions(MarketableTransactions MT, DeliverableTransactions DT, VerifiableTransactions VT, ArchiveableTransactions AT, OffLineTransactions[] OffLineTransations);
}
